using BlueBook.Helpers;
using BlueBook.Model;
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
            // CHECK ALL WORDS IN PHRASE ACTUALLY EXIST
            // IF NOT, DISPLAY LIST OF WORDS NOT IN DB AND ASK IF USER WANTS TO ADD THEM

            // NULL CHECKING

            return true;
        }

        public void Execute(object parameter)
        {
            List<string> wordsNotInDB = _dr.WordsNotFoundInDB(VM.EnteredPhrase);

            if (wordsNotInDB.Count > 0)
            {
                // COULD UPDATE VM INSTEAD OF USING A MESSAGEBOX

                string wordsNotFound = "";

                foreach (var word in wordsNotInDB)
                {
                    wordsNotFound = $"{wordsNotFound}, {word}";
                }

                MessageBox.Show($"The following word(s): {wordsNotFound} were not found in the Database. Please add these words to Database and search again.");
                goto finish;
            }

            Dictionary<string, bool> selections = PopulateSelectionsDictionary();

            Phrase phrase = new Phrase(VM.EnteredPhrase, selections);

            

            phrase.PopulatePhraseAsListOfDictionaryIPA();

            VM.PhraseInIPA = IPAStringHelper.GetIPAStringFromDictionaryIPAList(phrase.PhraseAsListOfDictionaryIPA);

            List<string> tempWordView = new List<string>();

                // Run match algorithm
                phrase.FindMatches();

                // Build results
                ResultsBuilder rb = new ResultsBuilder(phrase.MatchedWords, phrase.FinalIndex, VM.PhraseInIPA);

                VM.Results = rb.BuildResults();
                VM.LeadingWords = rb.GetLeadingWords();
                VM.NumberOfResults = rb.GetNumberOfResults();


                foreach (var item in phrase.MatchedWords)
                {
                    string indexing = "";

                    for (int i = 0; i < item.Indexing.Count; i++)
                    {
                        indexing = $"{indexing}, {item.Indexing[i]}";
                    }

                    tempWordView.Add($"{item.Word.english}    {indexing}");
                }

                VM.TempWordView = tempWordView;

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
    }
}
