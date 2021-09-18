using BlueBook.Model;
using BlueBook.View;
using BlueBook.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BlueBook.ViewModel
{
    public class DictionaryWindowViewModel : INotifyPropertyChanged
    {

        // PLEASE TRY TO KEEP THIS ONLY FOR HANDING DISPLAY VARIABLES AND DATA
        public FindWordInDictionaryCommand FindWordInDictionaryCommand { get; set; }
        public AddNewRelationCommand AddNewRelationCommand { get; set; }


        public DictionaryWindow dictionaryWindow { get; set; }

        private DictionaryIPA _data;

        private DataRepo _dr;

        public DictionaryWindowViewModel()
        {
            //Get Data Object from repo
            _dr = new DataRepo();
            _data = _dr.GetSingleEntry("SELECT * FROM DictionaryIPA WHERE English = 'spasm'");

            //Put data into binding variables
            if (_data != null)
            {
                PrimaryWord = _data.english;
            }

            UpdateEntireEntry();

            //Assign bindings in View
            FindWordInDictionaryCommand = new FindWordInDictionaryCommand(this);
            AddNewRelationCommand = new AddNewRelationCommand(this);
        }

        private string primaryWord;
        public string PrimaryWord
        {
            get { return primaryWord; }
            set
            {
                primaryWord = value;
                OnPropertyChanged("PrimaryWord");
            }
        }

        private int primaryWordId;

        public int PrimaryWordID
        {
            get { return primaryWordId; }
            set 
            { 
                primaryWordId = value;
                OnPropertyChanged("PrimaryWordID");
            }
        }

        private string secondaryWord;

        public string SecondaryWord
        {
            get { return secondaryWord; }
            set
            {
                secondaryWord = value;
                OnPropertyChanged("SecondaryWord");
            }
        }

        private int secondaryWordId;

        public int SecondaryWordID
        {
            get { return secondaryWordId; }
            set 
            { 
                secondaryWordId = value;
                OnPropertyChanged("SecondaryWordID");
            }
        }

        private string primarySubString;

        public string PrimarySubString
        {
            get { return primarySubString; }
            set 
            { 
                primarySubString = value;
                OnPropertyChanged("PrimarySubString");
            }
        }

        private string secondarySubString;

        public string SecondarySubString
        {
            get { return secondarySubString; }
            set 
            { 
                secondarySubString = value;
                OnPropertyChanged("SecondarySubString");
            }
        }

        private List<string> wordRelationshipsList;

        public List<string> WordRelationshipsList
        {
            get { return wordRelationshipsList; }
            set 
            { 
                wordRelationshipsList = value;
                OnPropertyChanged("WordRelationshipsList");
            }
        }


        private string entireEntry;

        public string EntireEntry
        {
            get { return entireEntry; }
            set 
            { 
                entireEntry = value;
                OnPropertyChanged("EntireEntry");
            }
        }


        public void SearchForWord()
        {
            _data = _dr.GetSingleEntry($"SELECT * FROM DictionaryIPA WHERE English = '{PrimaryWord}'");
            PrimaryWordID = _data.id;
            UpdateEntireEntry();
            GetWordRelationships();
        }

        private void GetWordRelationships()
        {
            WordRelationshipsList = _dr.GetListOfDictionaryRelations(PrimaryWordID);
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        public void UpdateEntireEntry()
        {
            if (_data != null)
            {
                EntireEntry = $"{_data.id}, {_data.english}, {_data.ipa1}, {_data.ipa2}, {_data.ipa3}";
            }
        }

        public void GetIndexForLinkingWord()
        {
            SecondaryWordID = _dr.FindIndexOfWord(PrimaryWord);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
