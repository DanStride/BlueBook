using BlueBook.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class MatchedWord
    {
        public DictionaryIPA Word { get; set; }

        public List<byte[]> ByteArrayList = new List<byte[]>();

        public List<int> Indexing = new List<int>();

        public bool isMatch;

        public MatchedWord(DictionaryIPA word, List<int> index)
        {
            Word = word;
            Indexing = index;
        }

        public MatchedWord(List<byte[]> word)
        {
            ByteArrayList = word;

            for (int i = 0; i < word.Count; i++)
            {
                Indexing.Add(-1);
            }
        }

        public MatchedWord()
        {

        }

        public override string ToString()
        {
            return Word.english;
        }


    }
}
