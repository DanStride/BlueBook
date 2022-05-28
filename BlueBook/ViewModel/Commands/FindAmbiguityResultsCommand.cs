using BlueBook.Helpers;
using BlueBook.Logic;
using BlueBook.Model;
using BlueBook.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

namespace BlueBook.ViewModel.Commands
{
    public class FindAmbiguityResultsCommand : ICommand
    {
        public FinderWindowViewModel VM { get; set; }
        private DataRepo _dr { get; set; }

        private BackgroundWorker _worker;

        private SearchObject searchObject;

        ResultData rData;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public FindAmbiguityResultsCommand(FinderWindowViewModel vm)
        {
            VM = vm;
            _dr = new DataRepo();
            
            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_GetResults;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            rData = new ResultData();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
            }
            else
            {
                rData = (ResultData)e.Result;
                VM.PhraseInIPA = IPAStringHelper.ConvertPhraseToIPAChars(VM.EnteredPhrase);
                VM.Results = rData.Results;
                VM.LeadingWords = rData.LeadingWords;
                VM.NumberOfResults = rData.Results.Count.ToString();
                VM.Progress = "Complete";
            }
        }

        private void _worker_GetResults(object sender, DoWorkEventArgs e)
        {


            BackgroundWorker worker = sender as BackgroundWorker;

            SearchObject searchObject = (SearchObject)e.Argument;

            AmbiguitySearcher ambiguitySearcher = new AmbiguitySearcher(searchObject._phrase, searchObject._selections);

            List<DictionaryIPA> list = ambiguitySearcher.ConvertPhraseIntoListOfDictionaryIPA(searchObject._phrase);

            int finalIndex = ambiguitySearcher.GetFinalIndex(list);

            List<MatchedWord> matches = ambiguitySearcher.FindMatches(list);

            ResultBuilder resultBuilder = new ResultBuilder();
            resultBuilder.OnProgressUpdate += ResultBuilder_OnProgressUpdate;


            e.Result = resultBuilder.BuildResults(matches, finalIndex);
        }

        private void ResultBuilder_OnProgressUpdate(int value)
        {
            VM.Progress = $"{value}%";
        }

        public bool CanExecute(object parameter)
        {
            if (VM.EnteredPhrase.Length > 0)
            { return true; }
            else { return false; }
        }

        public void Execute(object parameter)
        {
            if (CheckWordsExist().Count > 0) goto finish;

            VM.Progress = "0%";

            searchObject = new SearchObject(PopulateSelectionsDictionary(), VM.EnteredPhrase);

            _worker.RunWorkerAsync(searchObject);

        finish:;
        }

        private Dictionary<string, bool> PopulateSelectionsDictionary()
        {

            Dictionary<string, bool> selectOptions = new Dictionary<string, bool>();
            if (VM.AmbiguousConsonants) selectOptions.Add("AmbiguousConsonants", true);
            if (!VM.AmbiguousConsonants) selectOptions.Add("AmbiguousConsonants", false);
            if (VM.AmbiguousVowels) selectOptions.Add("AmbiguousVowels", true);
            if (!VM.AmbiguousVowels) selectOptions.Add("AmbiguousVowels", false);

            return selectOptions;
        }

        private List<string> CheckWordsExist()
        {
            List<string> wordsNotInDB = _dr.WordsNotFoundInDB(VM.EnteredPhrase);

            if (wordsNotInDB.Count > 0)
            {
                string wordsNotFound = "";

                foreach (var word in wordsNotInDB)
                {
                    wordsNotFound = $"{wordsNotFound}, {word}";
                }

                MessageWindowViewModel mwvm = new MessageWindowViewModel(wordsNotInDB);
                MessageWindow messageWindow = new MessageWindow(mwvm);
                messageWindow.Show();
            }
            return wordsNotInDB;
        }
    }
}
