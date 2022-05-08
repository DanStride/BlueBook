using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class FindAmbiguityResultsWithoutLeadingWordsCommand : ICommand
    {
        // This is now doing nothing
        public FinderWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public FindAmbiguityResultsWithoutLeadingWordsCommand(FinderWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            // CHECK ALL WORDS IN PHRASE ACTUALLY EXIST
            // IF NOT, DISPLAY LIST OF WORDS NOT IN DB AND ASK IF USER WANTS TO ADD THEM

            return true;
        }

        public void Execute(object parameter)
        {
            // REBUILD THIS BASED ON THE OTHER ONE 

            //List<string> tempWordView = new List<string>();


            //Dictionary<string, bool> selections = PopulateSelectionsDictionary();


            //// Build new phrase obj
            //Phrase phrase = new Phrase(VM.EnteredPhrase, selections);

            //// Populate word list from phrase
            ////bool wordIsInDatabase = phrase.AddWordsToWordsIPAList();



            //if (wordIsInDatabase)
            //{
            //    // Populate IPA string field
            //    VM.PhraseInIPA = phrase.GetIPAStringFromWordsIPAList();

            //    // Run match algorithm
            //    phrase.FindMatches();

            //    // Build results
            //    ResultsBuilder rb = new ResultsBuilder(phrase.MatchedWords, phrase.FinalIndex, VM.PhraseInIPA);

            //    rb.RemoveLeadingWords();

            //    VM.Results = rb.BuildResults();
            //    VM.LeadingWords = rb.GetLeadingWords();


            //    foreach (var item in phrase.MatchedWords)
            //    {
            //        string indexing = "";

            //        for (int i = 0; i < item.Indexing.Count; i++)
            //        {
            //            indexing = $"{indexing}, {item.Indexing[i]}";
            //        }

            //        tempWordView.Add($"{item.Word.english}    {indexing}");
            //    }

            //    VM.TempWordView = tempWordView;
            //}
            //else
            //{

            //}

        }

        private Dictionary<string, bool> PopulateSelectionsDictionary()
        {

            Dictionary<string, bool> selectOptions = new Dictionary<string, bool>();


            if (VM.AmbiguousConsonants) selectOptions.Add("AmbiguousConsonants", true);

            if (!VM.AmbiguousConsonants) selectOptions.Add("AmbiguousConsonants", false);

            if (VM.AmbiguousConsonants) selectOptions.Add("AmbiguousVowels", true);

            if (!VM.AmbiguousConsonants) selectOptions.Add("AmbiguousVowels", false);


            return selectOptions;
        }
    }
}
