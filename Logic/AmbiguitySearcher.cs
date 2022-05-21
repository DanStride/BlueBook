using BlueBook.Helpers;
using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBook.Logic
{
    public class AmbiguitySearcher
    {
        private Dictionary<string, bool> selections;
        private DataRepo _dr;
        private MatchRules _rules;

        private string enteredPhrase;

        public string EnteredPhrase
        {
            get { return enteredPhrase; }
            set { enteredPhrase = value; }
        }

        public AmbiguitySearcher(string phrase, Dictionary<string, bool> selection)
        {
            selections = selection;
            EnteredPhrase = phrase;
            _dr = new DataRepo();
            _rules = new MatchRules(selection);
        }

        public ResultData ProcessAndReturnResults(SearchObject searchObject)
        {

            List<DictionaryIPA> list = ConvertPhraseIntoListOfDictionaryIPA(searchObject._phrase);

            int finalIndex = GetFinalIndex(list);

            List<MatchedWord> matches = FindMatches(list);

            ResultBuilder resultBuilder = new ResultBuilder();

            ResultData resultData = resultBuilder.BuildResults(matches, finalIndex);

            return resultData;
        }

        public List<DictionaryIPA> ConvertPhraseIntoListOfDictionaryIPA(string phrase)
        {
            List<string> wordList = IPAStringHelper.SplitWordsIntoList(phrase);
            List<DictionaryIPA> dictionaryIPA = new List<DictionaryIPA>();

            for (int i = 0; i < wordList.Count; i++)
            {
                dictionaryIPA.Add(_dr.GetSingleEntry(wordList[i]));
            }

            return dictionaryIPA;
        }

        public int GetFinalIndex(List<DictionaryIPA> list)
        {
            string ipaString = "";

            foreach (var word in list)
            {
                ipaString = $"{ipaString}{String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            List<byte[]> phraseBytes = IPAStringHelper.GetByteListFromIPAString(ipaString);
            phraseBytes = IPAStringHelper.GetByteListFromIPAString(ipaString);

            return phraseBytes.Count - 1;
        }

        public List<MatchedWord> FindMatches(List<DictionaryIPA> dictionaryIPA)
        {
            List<MatchedWord> matches = new List<MatchedWord>();
            List<DictionaryIPA> dbList = _dr.GetEntireDictionaryIPAList();
            string ipaString = "";

            foreach (var word in dictionaryIPA)
            {
                ipaString = $"{ipaString}{String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            List<byte[]> phraseBytes = new List<byte[]>();
            phraseBytes = IPAStringHelper.GetByteListFromIPAString(ipaString);
            List<byte[]> wordBytes = new List<byte[]>();


            for (int i = 0; i < dbList.Count; i++)
            {
                wordBytes = IPAStringHelper.GetByteListFromIPAString(dbList[i].ipa1);

                if (CheckForMatch(phraseBytes, wordBytes).ByteArrayList.Count > 0)
                {
                    MatchedWord match = CheckForMatch(phraseBytes, wordBytes);

                    match.Word = dbList[i];

                    if (match.Indexing.Count > 0 && CheckMatchActuallyHasMatches(match))
                    {
                        matches.Add(match);
                    }
                }
            }
            return matches;
        }

        public MatchedWord CheckForMatch(List<byte[]> phrase, List<byte[]> word)
        {
            MatchedWord match = new MatchedWord();

            for (int wi = 0; wi < word.Count; wi++)
            {
                if (wi != 0)
                {
                    if (BytesMatch(phrase[0], word[wi]))
                    {
                        if (ParallelMatchCheck(phrase, word, 0, wi).isMatch)
                        {
                            match = ParallelMatchCheck(phrase, word, 0, wi);
                            goto Exit;
                        }
                    }
                }
                else
                {
                    for (int pi = 0; pi < phrase.Count; pi++)
                    {
                        if (BytesMatch(phrase[pi], word[wi]))
                        {
                            if (ParallelMatchCheck(phrase, word, pi, wi).isMatch)
                            {
                                match = ParallelMatchCheck(phrase, word, pi, wi);
                                goto Exit;
                            }
                        }
                    }
                }
            }
        Exit:;
            return match;
        }

        private bool BytesMatch(byte[] phrase, byte[] word)
        {
            bool byteMatch = false;

            if (!selections.ContainsValue(true))
            {
                byteMatch = phrase.SequenceEqual(word);
            }
            else
            {
                byteMatch = BytesMatchOnAmbiguity(phrase, word);
            }

            return byteMatch;
        }

        private bool BytesMatchOnAmbiguity(byte[] phrase, byte[] word)
        {
            bool byteMatch = false;

            string phraseAsCharString = IPAStringHelper.GetStringFromByteArray(phrase);

            if (selections["AmbiguousConsonants"] == true && AmbiguityRules.allConsonants.Contains(phraseAsCharString))
            {
                if (_rules.IsAmbiguousConsonantMatch(phraseAsCharString, word))
                {
                    byteMatch = true;
                    goto finish;
                }
            }

            if (selections["AmbiguousVowels"] == true && AmbiguityRules.allVowels.Contains(phraseAsCharString))
            {
                if (_rules.IsAmbiguousVowelMatch(phraseAsCharString, word))
                {
                    byteMatch = true;
                    goto finish;
                }
            }

            byteMatch = phrase.SequenceEqual(word);

        finish:;
            return byteMatch;

        }

        public MatchedWord ParallelMatchCheck(List<byte[]> phrase, List<byte[]> word, int phraseIndex, int wordIndex)
        {
            MatchedWord match = new MatchedWord(word);
            match.isMatch = true;

            if (phrase.Count - phraseIndex > word.Count - wordIndex)
            {
                for (int i = 0; i < word.Count - wordIndex; i++)
                {
                    if (!BytesMatch(phrase[i + phraseIndex], word[i + wordIndex]))
                    {
                        match.isMatch = false;
                        break;
                    }
                    else
                    {
                        match.Indexing.RemoveAt(i + wordIndex);
                        match.Indexing.Insert(i + wordIndex, i + phraseIndex);
                    }
                }
            }
            else
            {
                for (int i = 0; i < phrase.Count - phraseIndex; i++)
                {
                    if (!BytesMatch(phrase[i + phraseIndex], word[i + wordIndex]))
                    {
                        match.isMatch = false;
                        break;
                    }
                    else
                    {
                        match.Indexing.RemoveAt(i + wordIndex);
                        match.Indexing.Insert(i + wordIndex, i + phraseIndex);
                    }
                }
            }

            return match;
        }

        private bool CheckMatchActuallyHasMatches(MatchedWord matchedWord)
        {
            bool hasMatch = false;
            for (int i = 0; i < matchedWord.Indexing.Count; i++)
            {
                if (matchedWord.Indexing[i] != -1)
                {
                    hasMatch = true;
                    break;
                }
            }
            return hasMatch;
        }

    }

}
