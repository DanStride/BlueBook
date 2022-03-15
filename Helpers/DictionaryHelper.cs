using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BlueBook.Model;
using BlueBook.Static_Classes;
using SQLite;

namespace BlueBook.Helpers
{
    public class DictionaryHelper
    {
        private string dbPath = ($"{Directory.GetCurrentDirectory()}\\DictionaryIPA.db");
        private string ipaFile = "H:\\2021 PROGRAMMING\\Blue Book\\resources\\en_UK.txt";

        private SQLiteConnection _db;

        public DictionaryHelper()
        {
            //Open DB
            _db = new SQLiteConnection(dbPath);
            _db.CreateTable<DictionaryIPA>();
            _db.CreateTable<AlphabetDBModel>();
        }
        public void AddWordsToDB()
        {
            char[] splitChars = { ' ', '/' };
            char[] charsToRemove = { '\'', 'ˈ', 'ˌ', '\t' }; 

            //Delete table and create new one
            _db.Query<DictionaryIPA>("DROP TABLE DictionaryIPA");
            _db.CreateTable<DictionaryIPA>();

            //Open streamreader
            using (StreamReader sr = new StreamReader(ipaFile))
            {
                //Parse and clean each line, add each one to DB
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Split
                    string[] splits = line.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                    //Clean
                    for (int i = 0; i < splits.Length; i++)
                    {
                        splits[i] = splits[i].Trim(charsToRemove);
                    }

                    splits[1] = IPAStringHelper.CleanIPA(splits[1]);


                   

                    var dictionaryIPA = new DictionaryIPA
                    {
                        english = splits[0],
                        ipa1 = splits[1]
                    };

                    if (splits.Length > 2)
                    {
                        dictionaryIPA.ipa2 = splits[2];
                    }

                    if (splits.Length > 3)
                    {
                        dictionaryIPA.ipa3 = splits[3];
                    }

                    System.Diagnostics.Debug.WriteLine(splits[0]);

                    //Add to DB
                    _db.Insert(dictionaryIPA);
                }
            };
            
            //Close
        }

        public void BuildAlphabetDB()
        {
            _db.Query<AlphabetDBModel>("DROP TABLE IPAlphabet");
            _db.CreateTable<AlphabetDBModel>();
            AlphabetDBModel model = new AlphabetDBModel();


            foreach (var item in IPAlphabet.ipaChars)
            {
                model.id = item.charId;
                model.character = item.character.ToString();
                model.charType = item.characterType.ToString();
                model.vowelType = item.vowelType.ToString();
                model.vowelHeight = item.vowelHeight.ToString();
                model.vowelBackness = item.vowelBackness.ToString();
                model.vowelRoundedness = item.vowelRoundedness.ToString();
                model.consonantVoicing = item.consonantVoicing.ToString();
                model.consonantPlaceOfArticulation = item.consonantPlaceOfArticulation.ToString();
                model.consonantMannerOfArticualation = item.consonantMannerOfArticulation.ToString();

                _db.Insert(model);
            }
        }
    }
}
