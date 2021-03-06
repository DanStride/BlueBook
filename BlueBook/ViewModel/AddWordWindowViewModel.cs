using BlueBook.Model;
using BlueBook.Static_Classes;
using BlueBook.View;
using BlueBook.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace BlueBook.ViewModel
{
    public class AddWordWindowViewModel : INotifyPropertyChanged
    {
        public AddWordWindow addWordWindow { get; set; }

        private DataRepo _dr;

        private IPAlphabet _ipa = new IPAlphabet();

        public AddWordCharacterSelectCommand AddWordCharacterSelectCommand { get; set; }
        public AddWordCommand AddWordCommand { get; set; }

        public delegate void ClickOption(string option);
        public event ClickOption OnClickOption;

        private List<string> ipaChars = new List<string>();

        public List<string> IpaChars
        {
            get { return ipaChars; }
            set 
            { 
                ipaChars = value;
                OnPropertyChanged("IpaChars");
            }
        }

        private string charString;

        public string CharString
        {
            get { return charString; }
            set 
            { 
                charString = value;
                OnPropertyChanged("CharString");
            }
        }

        private List<string> newWordIPAList = new List<string>();

        public List<string> NewWordIPAList
        {
            get { return newWordIPAList; }
            set 
            { 
                newWordIPAList = value;
                OnPropertyChanged("NewWordIPAs");
            }
        }

        private string newWordIPAString;

        public string NewWordIPAString
        {
            get { return newWordIPAString; }
            set 
            { 
                newWordIPAString = value;
                OnPropertyChanged("NewWordIPAString");
            }
        }

        private string newWord;

        public string NewWord
        {
            get { return newWord; }
            set 
            { 
                newWord = value;
                OnPropertyChanged("NewWord");
            }
        }






        public AddWordWindowViewModel()
        {
            AddWordCharacterSelectCommand = new AddWordCharacterSelectCommand(this);
            AddWordCommand = new AddWordCommand(this);
            AddWordCommand.OnClickOption += AddWordCommand_OnClickOption;

            _dr = new DataRepo();

            PopulateIPACharsList();
            CharString = String.Join("   ", IpaChars);
        }

        private void AddWordCommand_OnClickOption(string option)
        {
            OnClickOption(option);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void PopulateIPACharsList()
        {
            foreach (var letter in _ipa.ipaChars)
            {
                ipaChars.Add(letter.character);
            }
        }

        public void AddIPACharToNewWord(string newChar)
        {
            NewWordIPAList.Add(newChar);
            NewWordIPAString = String.Join("", NewWordIPAList);
        }

        public void BackspaceLastChar()
        {
            if (NewWordIPAList.Count > 0)
            {
                NewWordIPAList.RemoveAt(NewWordIPAList.Count - 1);
                NewWordIPAString = String.Join("", NewWordIPAList);
            }
        }

        public void AddNewWordToDataBase()
        {
                DictionaryIPA newIPA = new DictionaryIPA();

                newIPA.english = NewWord;
                newIPA.ipa1 = NewWordIPAString;
                _dr.AddNewDictionaryIPA(newIPA);
        }
    }
}
