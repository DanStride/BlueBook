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

        private string enteredPhrase;

        public FinderWindowViewModel()
        {
            FindAmbiguityResultsCommand = new FindAmbiguityResultsCommand(this);
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

        private List<AmbiguityResults> ambiguityResults;

        public List<AmbiguityResults> AmbiguityResults
        {
            get { return ambiguityResults; }
            set 
            { 
                ambiguityResults = value;
                OnPropertyChanged("AmbiguityResults");
            }
        }







        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
