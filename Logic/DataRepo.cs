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
        private DictionaryRelations _drel;
        private DatabaseHelper _dh;

        public DataRepo()
        {
            _data = new DictionaryIPA();
            _drel = new DictionaryRelations();
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
            DictionaryIPA dipa = _dh.ReturnSingleDBQuery($"SELECT * FROM DictionaryIPA WHERE English = '{word}'");

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
            listIPA = _dh.GetListOfDictionaryIPA("SELECT * FROM DictionaryIPA");
            return listIPA;
        }

        public List<string> GetListOfDictionaryRelations(int wordId)
        {
            List<DictionaryRelations> drelList = new List<DictionaryRelations>();
            DictionaryIPA dipa = new DictionaryIPA();
            List<string> relationList = new List<string>();

            drelList = _dh.ReturnDictionaryRelationsList($"SELECT SecondaryWordID FROM DictionaryRelations WHERE PrimaryWordID = {wordId}");

            foreach (var relation in drelList)
            {
                dipa = GetSingleEntry($"SELECT English FROM DictionaryIPA WHERE ID = '{relation.secondaryWordId}'");
                relationList.Add(dipa.english);
            }

            return relationList;
        }

        public DictionaryIPA GetSingleEntry(string selector)
        {

            //Run search query
            _data = _dh.ReturnSingleDBQuery(selector);
   
            //Return result
            return _data;
        }

        public string GetWordIPA(string word)
        {
            _data = _dh.ReturnSingleDBQuery($"SELECT IPA1 FROM DictionaryIPA WHERE English = '{word}'");

            return _data.ipa2.ToString();
        }

        public void InsertDictionaryRelation(DictionaryRelations dr)
        {
            _dh.InsertIntoDB(dr);
        }

        public DictionaryRelations BuildDictionaryRelationsObject(string primaryWord, string secondaryWord, string primaryWordSubString, string secondaryWordSubString)
        {
            bool wordsExist = true;
            int primaryWordId = 0;
            int secondaryWordId = 0;
            int primaryWordStartIndex = 0;
            int primaryWordEndIndex = 0;
            int secondaryWordStartIndex = 0;
            int secondaryWordEndIndex = 0;

            if (primaryWord != null && secondaryWord != null && primaryWordSubString != null && secondaryWordSubString != null)
            {

                // Check words exist in db
                _data = _dh.ReturnSingleDBQuery($"SELECT ID FROM DictionaryIPA WHERE English = '{primaryWord}'");
                if (_data.id > 0)
                {
                    primaryWordId = _data.id;
                    //GOTO would be nice here
                }
                else
                {
                    wordsExist = false;
                }

                _data = _dh.ReturnSingleDBQuery($"SELECT ID FROM DictionaryIPA WHERE English = '{secondaryWord}'");
                if (_data.id > 0)
                {
                    secondaryWordId = _data.id;
                }
                else
                {
                    wordsExist = false;
                }

                if (wordsExist)
                {
                    // Check that substrings are contained within words
                    if (primaryWord.Contains(primaryWordSubString) && secondaryWord.Contains(secondaryWordSubString))
                    {
                        // Get Indices from substrings/string
                        primaryWordStartIndex = primaryWord.IndexOf(primaryWordSubString) + 1;
                        primaryWordEndIndex = primaryWordStartIndex + primaryWordSubString.Length - 1;

                        secondaryWordStartIndex = secondaryWord.IndexOf(secondaryWordSubString) + 1;
                        secondaryWordEndIndex = secondaryWordStartIndex + secondaryWordSubString.Length - 1;

                        // Set object data
                        _drel.primaryWordId = primaryWordId;
                        _drel.secondaryWordId = secondaryWordId;
                        _drel.primaryWordStartIndex = primaryWordStartIndex;
                        _drel.primaryWordEndIndex = primaryWordEndIndex;
                        _drel.secondaryWordStartIndex = secondaryWordStartIndex;
                        _drel.secondaryWordEndIndex = secondaryWordEndIndex;
                    }
                }
                else
                {
                    MessageBox.Show("One or both of those words do not exist in the database");
                }
            }

            return _drel;
        }

        public int FindIndexOfWord (string word)
        {
            DictionaryIPA dictionaryIPA = _dh.ReturnSingleDBQuery($"SELECT ID FROM DictionaryIPA WHERE English = '{word}'");

            return dictionaryIPA.id;
        }

        public DictionaryRelations GetDictionaryRelations()
        {
            return _drel;
        }

        public List<DictionaryIPA> GetListOfWords(string query)
        {
            List<DictionaryIPA> listIPA = new List<DictionaryIPA>();

            listIPA = _dh.GetListOfDictionaryIPA(query);

            return listIPA;
        }

        public void FixDataBaseThirteenThirtytwoProblem()
        {
            // for each db entry
            // convert to byte and back to string
            // add to ipa 2 so can see if its ok
            List<DictionaryIPA> listIPA = _dh.GetEntireDBList();

            foreach (var word in listIPA)
            {
                DictionaryIPA dipa = word;

                List<byte[]> byteList = IPAStringHelper.GetByteListFromIPAString(word.ipa1);
                List<string>  stringList = IPAStringHelper.GetStringListFromByteList(byteList);

                dipa.ipa2 = String.Concat(stringList);

                _dh.UpdateDBEntry(dipa);
            }

        }

        public int GetDataBaseCount()
        {
            return _dh.GetDataBaseCount();
        }

        public void AddNewDictionaryIPA(DictionaryIPA dipa)
        {
            _dh.InsertIntoDB(dipa);
        }
    }

}
