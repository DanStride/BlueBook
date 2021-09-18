using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class FindAmbiguityResultsCommand : ICommand
    {
        public FinderWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public FindAmbiguityResultsCommand(FinderWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            // CHECK ALL WORDS IN PHRASE ACTUALLY EXIST

            return true;
        }

        public void Execute(object parameter)
        {
            // Build new phrase obj
            Phrase phrase = new Phrase(VM.EnteredPhrase);

            // Populate word list from phrase
            phrase.AddWordsToWordsIPAList();

            // Populate IPA string field
            VM.PhraseInIPA = phrase.GetIPAStringFromWordsIPAList();

            // Run match algorithm
            phrase.FindMatches();

            // Build results
            AmbiguityResults results = new AmbiguityResults(phrase.MatchedWords);

        }
    }
}
