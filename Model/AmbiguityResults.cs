using BlueBook.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class AmbiguityResults
    {
        public List<MatchedWord> matchedWordList { get; set; }

        public AmbiguityResults(List<MatchedWord> matches)
        {
            matchedWordList = matches;
        }

        public void BuildResults()
        {
            // There is a total index size for the phrase
            // You need to build it like a grid
            // 
        }



        public List<DictionaryIPA> words = new List<DictionaryIPA>();

        private List<string> wordIPAList;

        public List<string> WordIPAList
        {
            get { return wordIPAList; }
            set { wordIPAList = value; }
        }

        private List<string> phraseIPAList;

        public List<string> PhraseIPAList
        {
            get { return phraseIPAList; }
            set { phraseIPAList = value; }
        }

        public AmbiguityResults(DictionaryIPA word, List<string> phrase)
        {
            words.Add(word);
            PhraseIPAList = phrase;
        }

        public void GetPhraseIPAList()
        {
            //WordIPAList = IPAStringHelper.GetStringListFromString(words[0]);
        }

        public bool CheckCharacterMatch(string character)
        {
            bool itMatches = true;



            return itMatches;
        }

        //override ToString method
    }
}
