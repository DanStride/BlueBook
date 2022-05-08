using BlueBook.Model;
using BlueBook.View;
using BlueBook.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlueBook.ViewModel
{
    public class FinderWindowViewModel : INotifyPropertyChanged
    {
        public FinderWindow finderWindow { get; set; }
        public FindAmbiguityResultsCommand FindAmbiguityResultsCommand { get; set; }

        public FindAmbiguityResultsWithoutLeadingWordsCommand FindAmbiguityResultsWithoutLeadingWordsCommand { get; set; }
        public ShowAddWordWindowCommand ShowAddWordWindowCommand { get; set; }

        private string enteredPhrase;

        public FinderWindowViewModel()
        {
            FindAmbiguityResultsCommand = new FindAmbiguityResultsCommand(this);
            FindAmbiguityResultsWithoutLeadingWordsCommand = new FindAmbiguityResultsWithoutLeadingWordsCommand(this);
            ShowAddWordWindowCommand = new ShowAddWordWindowCommand(this);
        }

        public string EnteredPhrase
        {
            get { return enteredPhrase; }
            set 
            { 
                enteredPhrase = value;
                OnPropertyChanged("EnteredPhrase");
            }
        }

        private string phraseInIPA;

        public string PhraseInIPA
        {
            get { return phraseInIPA; }
            set 
            { 
                phraseInIPA = value;
                OnPropertyChanged("PhraseInIPA");
            }
        }

        private AmbiguityResults ambiguityResults;

        public AmbiguityResults AmbiguityResults
        {
            get { return ambiguityResults; }
            set 
            { 
                ambiguityResults = value;
                OnPropertyChanged("AmbiguityResults");
            }
        }

        private List<string> wordsNotFound;

        public List<string> WordsNotFound
        {
            get { return wordsNotFound; }
            set { wordsNotFound = value; }
        }

        private List<string> tempWordView = new List<string>();

        public List<string> TempWordView
        {
            get { return tempWordView; }
            set 
            { 
                tempWordView = value;
                OnPropertyChanged("TempWordView");
            }
        }

        private List<Result> results;

        public List<Result> Results
        {
            get { return results; }
            set 
            { 
                results = value;
                OnPropertyChanged("Results");
                //NumberOfResults = $"{Results.Count}";
            }
        }

        private List<Result> leadingWords;

        public List<Result> LeadingWords
        {
            get { return leadingWords; }
            set 
            { 
                leadingWords = value;
                OnPropertyChanged("LeadingWords");
            }
        }


        private bool ambiguousConsonants;

        public bool AmbiguousConsonants
        {
            get { return ambiguousConsonants; }
            set 
            { 
                ambiguousConsonants = value;
                OnPropertyChanged("AmbiguousConsonants");
            }
        }


        private bool ambiguousVowels;

        public bool AmbiguousVowels
        {
            get { return ambiguousVowels; }
            set 
            { 
                ambiguousVowels = value;
                OnPropertyChanged("AmbiguousVowels");
            }
        }

        private string numberOfResults = "";

        public string NumberOfResults
        {
            get { return numberOfResults; }
            set 
            { 
                numberOfResults = value;
                OnPropertyChanged("NumberOfResults");
            }
        }










        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
