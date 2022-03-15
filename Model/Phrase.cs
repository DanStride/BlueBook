using BlueBook.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace BlueBook.Model
{
    public class Phrase
    {
        // THINK ABOUT RENAMING THIS CLASS

        private DataRepo _dr;


        // MAYBE THE SAME FOR MATCH RULES, ACTUALLY MATCH RULES SHOULD COME FROM A DB WITH FUNCTIONALITY TO MODIFY FROM WITHIN PROGRAM
        private MatchRules mr;

        private string enteredPhraseAsString;
        public string EnteredPhraseAsString
        {
            get { return enteredPhraseAsString; }
            set { enteredPhraseAsString = value; }
        }


        private List<DictionaryIPA> phraseAsListOfDictionaryIPA;
        public List<DictionaryIPA> PhraseAsListOfDictionaryIPA
        {
            get { return phraseAsListOfDictionaryIPA; }
            set { phraseAsListOfDictionaryIPA = value; }
        }


        private List<MatchedWord> matchedWords = new List<MatchedWord>();
        public List<MatchedWord> MatchedWords
        {
            get { return matchedWords; }
            set { matchedWords = value; }
        }


        char[] splitChars = { ' ' };

        private List<DictionaryIPA> dbList;



        public string ipaString = "";

        private int finalIndex;

        public int FinalIndex
        {
            get { return finalIndex; }
            set { finalIndex = value; }
        }

        private List<string> alternatePhraseIPAs;

        public List<string> AlternatePhraseIPAs

        {
            get { return alternatePhraseIPAs; }
            set { alternatePhraseIPAs = value; }
        }

        private Dictionary<string, bool> selectionOptions;

        public Dictionary<string, bool> SelectionOptions
        {
            get { return selectionOptions; }
            set { selectionOptions = value; }
        }

        public List<byte[]> matchRuleSet { get; set; }


        public Phrase(string phrase, Dictionary<string, bool> selectOptions)
        {
            EnteredPhraseAsString = phrase;
            _dr = new DataRepo();
            PhraseAsListOfDictionaryIPA = new List<DictionaryIPA>();
            dbList = _dr.GetEntireDictionaryIPAList();
            AlternatePhraseIPAs = new List<string>();
            SelectionOptions = selectOptions;
            mr = new MatchRules(selectionOptions);
        }


        public void PopulatePhraseAsListOfDictionaryIPA()
        {
            List<string> wordList = IPAStringHelper.SplitWordsIntoList(EnteredPhraseAsString);

            for (int i = 0; i < wordList.Count; i++)
            {
                PhraseAsListOfDictionaryIPA.Add(_dr.GetSingleEntry($"SELECT * FROM DictionaryIPA WHERE English = '{wordList[i]}'"));
            }
        }

        public void AddMatchedWord(DictionaryIPA word, List<int> index)
        {
            MatchedWords.Add(new MatchedWord(word, index));
        }



        public void FindMatches()
        {
            // NEEDS SEPARATION, THIS SHOULD REALLY BE THE TEMPLATE METHOD THAT CALLS ALL THE OTHER STEPS
            // SHOULD RETURN RESULTS OBJECT/LIST


            string ipaString = "";

            // CALL METHOD GetIPAStringFromWordsIPAList
            foreach (var word in PhraseAsListOfDictionaryIPA)
            {
                ipaString = $"{ipaString}{String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            // This can be set once
            List<byte[]> phraseBytes = new List<byte[]>();
            phraseBytes = IPAStringHelper.GetByteListFromIPAString(ipaString);


            FinalIndex = phraseBytes.Count - 1;

            // This needs to be reset for each db entry
            List<byte[]> wordBytes = new List<byte[]>();

            //Open DB connection
            //Heaps quicker to return entire db as a collection rather than query one word at a time
            
            // EXTRACT METHOD FINDFIRSTWORDMATCHES
            for (int i = 0; i < dbList.Count; i++)
            {
                // NEED TO ADD MATCHEDWORD HERE AND ALSO ADD DICTIONARYIPA
                wordBytes = IPAStringHelper.GetByteListFromIPAString(dbList[i].ipa1);

                if (CheckForMatch(phraseBytes, wordBytes).ByteArrayList.Count > 0)
                {
                    MatchedWord match = CheckForMatch(phraseBytes, wordBytes);

                    match.Word = dbList[i];

                    if (match.Indexing.Count > 0 && CheckMatchActuallyHasMatches(match))
                    {
                        MatchedWords.Add(match);
                    }
                }
                
            }

        }

        

        private bool CheckMatchActuallyHasMatches(MatchedWord matchedWord)
        {
            // USEFUL CHECK BUT REALLY SHOULD BE TAKEN CARE OF EARLIER ON IN THE PROCESS

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

        public MatchedWord CheckForMatch(List<byte[]> phrase, List<byte[]> word)
        {
            // TOO LONG, NEED TO SEPARATE.

            MatchedWord match = new MatchedWord();
            // !!! ITERATION NEEDS TO START ON THE WORD AND NOT THE PHRASE
            for (int wi = 0; wi < word.Count; wi++)
            {
                // By the time word index has increased + 1 it can no longer be a trailing word therefore
                // the index wi when == 1 and above it MUST match on a pi == 0 or not at all
                if (wi != 0)

                    // EXTRACT METHOD AS LEADINGWORDMATCHCHECK
                {
                    if (BytesMatch(phrase[0], word[wi]))
                    {

                        //Continue checking the rest of the word by increasing indexes together
                        if (ParallelMatchCheck(phrase, word, 0, wi).isMatch)
                        {
                            // Add matched word to list of matched words
                            match = ParallelMatchCheck(phrase, word, 0, wi);
                            // Add a GOTO HERE to exit loop and stop it from adding lip 3 times                            << could be missing something here
                            goto Exit;
                        }
                    }
                }
                else
                {

                    // EXTRACT METHOD AS FOLLOWINGWORD MATCH CHECK

                    for (int pi = 0; pi < phrase.Count; pi++)
                    {
                        if (BytesMatch(phrase[pi], word[wi]))
                        {

                            //Continue checking the rest of the word by increasing indexes together
                            if (ParallelMatchCheck(phrase, word, pi, wi).isMatch)
                            {
                                // Add matched word to list of matched words
                                match = ParallelMatchCheck(phrase, word, pi, wi);
                                // Add a GOTO HERE to exit loop and stop it from adding lip 3 times                       << could be missing something here
                                goto Exit;
                            }
                        }
                    }
                }
            }
        Exit:;
            return match;
        }

        public MatchedWord ParallelMatchCheck(List<byte[]> phrase, List<byte[]> word, int phraseIndex, int wordIndex)
        {
            // TOO LONG, SEPARATE

            MatchedWord match = new MatchedWord(word);
            match.isMatch = true;

            // ADD EXPLANATION VARIABLE WORDISLONGERTHANPHRASE


            if(phrase.Count - phraseIndex > word.Count - wordIndex)
            {
                // Word is shorter than phrase so check to end of word and the remainder of word will have -1 indexes. Leading or trailing? Decide on terminology.                   << phrase is longer than word, should be no remainder
                // This doesn't need to add -1s anywhere because if it doesn't match entirely to the end of the word, it is not a match.
                // I THINK THIS IS CORRECT

                // EXTRACT METHOD OUT, RETURN MATCH

                for (int i = 0; i < word.Count - wordIndex; i++)
                {
                    if (!BytesMatch(phrase[i + phraseIndex], word[i + wordIndex]))
                    {
                        // If there is a non matching char before reaching the end of the word, it is not a match
                        match.isMatch = false;
                        break;
                    }
                    else
                    {
                        // If the rest of the word is a match you need to add to the index
                        match.Indexing.RemoveAt(i + wordIndex);
                        match.Indexing.Insert(i + wordIndex, i + phraseIndex);
                    }
                }
            }
            else
            {
                // Phrase is shorter than or equal to Word
                // This one does or does not need -1s? I think neither of them do
                // 

                // EXTRACT METHOD OUT, RETURN MATCH

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

        private bool BytesMatch(byte[] phrase, byte[] word)
        {
            bool byteMatch = false;

            if (!SelectionOptions.ContainsValue(true))
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

            if (SelectionOptions["AmbiguousConsonants"] == true && AmbiguityRules.allConsonants.Contains(phraseAsCharString))
            {

                if (mr.IsAmbiguousConsonantMatch(phraseAsCharString, word))
                {
                    byteMatch = true;
                    goto finish;
                }

            }

            if (SelectionOptions["AmbiguousVowels"] == true && AmbiguityRules.allVowels.Contains(phraseAsCharString))
            {
                if (mr.IsAmbiguousVowelMatch(phraseAsCharString, word))
                {
                    byteMatch = true;
                    goto finish;
                }
            }

            byteMatch = phrase.SequenceEqual(word);

            finish:;
            return byteMatch;

        }
    }
}
