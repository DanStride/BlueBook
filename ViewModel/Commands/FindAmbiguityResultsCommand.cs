using BlueBook.Helpers;
using BlueBook.Logic;
using BlueBook.Model;
using BlueBook.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class FindAmbiguityResultsCommand : ICommand
    {
        public FinderWindowViewModel VM { get; set; }
        private DataRepo _dr { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public FindAmbiguityResultsCommand(FinderWindowViewModel vm)
        {
            VM = vm;
            _dr = new DataRepo();
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
                       
            Dictionary<string, bool> selections = PopulateSelectionsDictionary();

            AmbiguitySearcher ambiguitySearcher = new AmbiguitySearcher(VM.EnteredPhrase, selections);

            ResultData resultData = ambiguitySearcher.ProcessAndReturnResults();

            VM.PhraseInIPA = IPAStringHelper.ConvertPhraseToIPAChars(VM.EnteredPhrase);
            VM.Results = resultData.Results;
            VM.LeadingWords = resultData.LeadingWords;
            VM.NumberOfResults = resultData.Results.Count.ToString();

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
