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

        //public string GetWordIPA(string word)
        //{
        //    _data = _dh.ReturnSingleDBQuery($"SELECT IPA1 FROM DictionaryIPA WHERE English = '{word}'");

        //    return _data.ipa2.ToString();
        //}
                
        //public int FindIndexOfWord (string word)
        //{
        //    DictionaryIPA dictionaryIPA = _dh.ReturnSingleDBQuery($"SELECT ID FROM DictionaryIPA WHERE English = '{word}'");

        //    return dictionaryIPA.id;
        //}

        //public List<DictionaryIPA> GetListOfWords(string query)
        //{
        //    List<DictionaryIPA> listIPA = new List<DictionaryIPA>();

        //    listIPA = _dh.GetListOfDictionaryIPA(query);

        //    return listIPA;
        //}

        //public void FixDataBaseThirteenThirtytwoProblem()
        //{
        //    List<DictionaryIPA> listIPA = _dh.GetEntireDBList();

        //    foreach (var word in listIPA)
        //    {
        //        DictionaryIPA dipa = word;

        //        List<byte[]> byteList = IPAStringHelper.GetByteListFromIPAString(word.ipa1);
        //        List<string>  stringList = IPAStringHelper.GetStringListFromByteList(byteList);

        //        dipa.ipa2 = String.Concat(stringList);

        //        _dh.UpdateDBEntry(dipa);
        //    }

        //}

        //public int GetDataBaseCount()
        //{
        //    return _dh.GetDataBaseCount();
        //}

        public void AddNewDictionaryIPA(DictionaryIPA dipa)
        {
            _dh.InsertIntoDB(dipa);
        }
    }

}
