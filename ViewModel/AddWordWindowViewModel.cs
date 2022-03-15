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

        public AddWordCharacterSelectCommand AddWordCharacterSelectCommand { get; set; }
        public AddWordCommand AddWordCommand { get; set; }

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

            _dr = new DataRepo();

            PopulateIPACharsList();
            CharString = String.Join("   ", IpaChars);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void PopulateIPACharsList()
        {
            foreach (var letter in IPAlphabet.ipaChars)
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
            //Check to see if word already exists
            if (_dr.VerifyExistenceOfWord(NewWord))
            {
                MessageBox.Show("Word already exists in DB");
            }
            else
            {
                //Build DictionaryIPA object
                DictionaryIPA newIPA = new DictionaryIPA();

                newIPA.english = NewWord;
                newIPA.ipa1 = NewWordIPAString;


                //Insert into DB
                _dr.AddNewDictionaryIPA(newIPA);

                //Inform user of success
                MessageBox.Show($"{NewWord} was successfully added to the database!");
            }

        }
    }
}
