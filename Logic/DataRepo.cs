using BlueBook.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlueBook.Model
{
    public class DataRepo
    {
        private DictionaryIPA _data;
        private DatabaseHelper _dh;

        public DataRepo()
        {
            _data = new DictionaryIPA();
            _dh = new DatabaseHelper();
        }

        public List<string> WordsNotFoundInDB(string phrase)
        {
            List<string> wordList = IPAStringHelper.SplitWordsIntoList(phrase);
            List<string> wordsNotInDB = new List<string>();

            for (int i = 0; i < wordList.Count; i++)
            {
                if (!VerifyExistenceOfWord(wordList[i]))
                {
                    wordsNotInDB.Add(wordList[i]);
                }
            }

            return wordsNotInDB;
        }

        public bool VerifyExistenceOfWord(string word)
        {
            DictionaryIPA dipa = _dh.ReturnSingleDBQuery(word);

            if (dipa != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DictionaryIPA> GetEntireDictionaryIPAList()
        {
            List<DictionaryIPA> listIPA = new List<DictionaryIPA>();
            listIPA = _dh.GetListOfDictionaryIPA();
            return listIPA;
        }

        public DictionaryIPA GetSingleEntry(string selector)
        {
            _data = _dh.ReturnSingleDBQuery(selector);
            return _data;
        }

        public void AddNewDictionaryIPA(DictionaryIPA dipa)
        {
            _dh.InsertIntoDB(dipa);
        }
    }

}
