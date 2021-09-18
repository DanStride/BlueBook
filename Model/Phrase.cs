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
        DataRepo _dr;
        private AlphabetIPA aipa = new AlphabetIPA();

        private string enteredPhrase;
        public string EnteredPhrase
        {
            get { return enteredPhrase; }
            set { enteredPhrase = value; }
        }


        private string convertedPhrase;
        public string ConvertedPhrase
        {
            get { return convertedPhrase; }
            set { convertedPhrase = value; }
        }

        private List<DictionaryIPA> wordsIPAList;
        public List<DictionaryIPA> WordsIPAList
        {
            get { return wordsIPAList; }
            set { wordsIPAList = value; }
        }

        private List<string> phraseIPAList;
        public List<string> PhraseIPAList
        {
            get { return phraseIPAList; }
            set { phraseIPAList = value; }
        }

        private List<MatchedWord> matchedWords = new List<MatchedWord>();
        public List<MatchedWord> MatchedWords
        {
            get { return matchedWords; }
            set { matchedWords = value; }
        }


        char[] splitChars = { ' ' };

        private List<DictionaryIPA> dbList = new List<DictionaryIPA>();

        public int indexLength;

        public string ipaString = "";




        public Phrase(string phrase)
        {
            EnteredPhrase = phrase;
            _dr = new DataRepo();
            WordsIPAList = new List<DictionaryIPA>();
            dbList = _dr.GetEntireDictionaryIPAList();
        }

        public void AddWordsToWordsIPAList()
        {
            List<string> wordList = IPAStringHelper.SplitWordsIntoList(EnteredPhrase);

            for (int i = 0; i < wordList.Count; i++)
            {
                if (_dr.VerifyExistenceOfWord(wordList[i]))
                {
                    WordsIPAList.Add(_dr.GetSingleEntry($"SELECT * FROM DictionaryIPA WHERE English = '{wordList[i]}'"));
                }
                else
                {
                    MessageBox.Show($"{wordList[i]} does not exist in the database");
                }
            }

        }

        public void GetIndexLengthForPhrase()
        {
            indexLength = IPAStringHelper.GetByteListFromString(ipaString).Count;
        }

        public string GetIPAStringFromWordsIPAList()
        {

            foreach (var word in WordsIPAList)
            {
                ipaString = $"{ipaString} {String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            return ipaString;
        }
        public void ConvertPhraseToIPAChars()
        {
            // put words into array
            string[] wordsEnglish = EnteredPhrase.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            // get ipa from dictionary

            for (int i = 0; i < wordsEnglish.Length; i++)
            {
                WordsIPAList.Add(_dr.GetSingleEntry($"SELECT * FROM DictionaryIPA WHERE English = '{wordsEnglish[i]}'"));
            }
        }

        public void AddMatchedWord(DictionaryIPA word, List<int> index)
        {
            MatchedWords.Add(new MatchedWord(word, index));
        }

        public void SearchForMatches()
        {
            // I THINK I SHOULD REWRITE THIS ENTIRE METHOD
            List<AmbiguityResults> ambiguityResults = new List<AmbiguityResults>();
            List<DictionaryIPA> wordsToRemove = new List<DictionaryIPA>();

            List<byte[]> phraseByteList = new List<byte[]>();
            List<string> phraseStringList = new List<string>();

            List<DictionaryIPA> wordList = new List<DictionaryIPA>();
            List<byte[]> wordByteList = new List<byte[]>();


            foreach (var word in WordsIPAList)
            {
                phraseByteList.AddRange(IPAStringHelper.GetByteListFromString(word.ipa1));
            }

            phraseStringList = IPAStringHelper.GetStringListFromByteList(phraseByteList);

            wordList = _dr.GetListOfWords($"SELECT * FROM DictionaryIPA WHERE IPA1 LIKE '%{phraseStringList[0]}%'");

            

            for (int i = 0; i < wordList.Count; i++)
            {
                List<int> currentIndexList = new List<int>(); 
                bool isAMatch = true;

                wordByteList = IPAStringHelper.GetByteListFromString(wordList[i].ipa1);

                for (int p = 0; p < phraseByteList.Count; p++)                                                  // STARTING INSIDE THE PHRASE
                {
                    for (int w = 0; w < wordByteList.Count; w++)                                                // MOVING THOUGH THE WORD 
                    {
                        if (BytesMatch(phraseByteList[p], wordByteList[w]))                                     // IF IT MATCHES
                        {
                            isAMatch = true;
                            // ADD START INDEX TO MATCHEDWORD HERE
                            currentIndexList.Add(p);

                            if (phraseByteList.Count - p > wordByteList.Count - w)                              // CHECK WHICH LIST IS LONGER, WANT TO INTERATE THROUGH THE SMALLER ONE. MINUS INDEX FOR WHAT LETTER WE ARE UP TO
                            {
                                // PHRASE IS LONGER SO THIS IS EITHER A START TO END OR MIDDLE TO END WORD
                                for (int x = 0; x < wordByteList.Count - w; x++)                                // CHECK THE REMAINDER OF THE WORD FOR MATCHES
                                {
                                    if (!BytesMatch(phraseByteList[p + x], wordByteList[w + x]))                // IF THE REMAINDER OF THE WORD DOES NOT MATCH, IS NOT MATCH, BREAK LOOP
                                    {
                                        isAMatch = false;
                                        currentIndexList.Add(-1);
                                        // MOVES TO NEXT LETTER OF WORD
                                        break;
                                    }
                                    else
                                    {
                                        currentIndexList.Add(p + x);
                                    }
                                    
                                }
                            }
                            else if (wordByteList.Count - w > phraseByteList.Count - p)
                            {
                                // WORD IS LONGER SO THIS IS EITHER A START TO MIDDLE OR MIDDLE TO MIDDLE WORD
                                for (int x = 0; x < phraseByteList.Count - p; x++)
                                {
                                    if (!BytesMatch(phraseByteList[p + x], wordByteList[w + x]))
                                    {
                                        isAMatch = false;
                                        currentIndexList.Add(-1);
                                        break;
                                    }
                                    else
                                    {
                                        currentIndexList.Add(p + x);
                                    }
                                }
                            }
                            if (isAMatch)
                            {
                                AddMatchedWord(wordList[i], currentIndexList);
                                goto NextWord;
                            }

                        }
                        else
                        {
                            currentIndexList.Add(-1);
                        }
                    }
                }


            //if (!isAMatch)
            //{
            //    wordsToRemove.Add(wordList[i]);
            //}
            NextWord:;
            }

            //wordList = wordList.Except(wordsToRemove).ToList();

        }

        public void FindMatches()
        {
            //phrase entered
            //add words to ipa list
            //search for matches

            //get list of byte[] from entered phrase

            //get list of list of byte[] from words

            //query db and return all results with first byte[] and then remove entries
            // OR
            //query db and check line by line
            string ipaString = "";

            foreach (var word in WordsIPAList)
            {
                ipaString = $"{ipaString}{String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            // This can be set once
            List<byte[]> phraseBytes = new List<byte[]>();
            phraseBytes = IPAStringHelper.GetByteListFromString(ipaString);

            // This needs to be reset for each db entry
            List<byte[]> wordBytes = new List<byte[]>();

            //Open DB connection
            //Heaps quicker to return entire db as a collection rather than query one word at a time
            
            for (int i = 0; i < dbList.Count; i++)
            {
                // NEED TO ADD MATCHEDWORD HERE AND ALSO ADD DICTIONARYIPA
                wordBytes = IPAStringHelper.GetByteListFromString(dbList[i].ipa1);

                if (CheckForMatch(phraseBytes, wordBytes).ByteArrayList.Count > 0)
                {
                    MatchedWord match = CheckForMatch(phraseBytes, wordBytes);
                    match.Word = dbList[i];
                    MatchedWords.Add(match);
                }
                
            }

        }


        public MatchedWord CheckForMatch(List<byte[]> phrase, List<byte[]> word)
        {
            MatchedWord match = new MatchedWord();
            // !!! ITERATION NEEDS TO START ON THE WORD AND NOT THE PHRASE
            for (int wi = 0; wi < word.Count; wi++)
            {
                // By the time word index has increased + 1 it can no longer be a trailing word therefore
                // the index wi when == 1 and above it MUST match on a pi == 0 or not at all
                if (wi != 0)
                {
                    if (BytesMatch(phrase[0], word[wi]))
                    {

                        //Continue checking the rest of the word by increasing indexes together
                        if (ParallelMatchCheck(phrase, word, 0, wi).isMatch)
                        {
                            // Add matched word to list of matched words
                            match = ParallelMatchCheck(phrase, word, 0, wi);
                            // Add a GOTO HERE to exit loop and stop it from adding lip 3 times
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

                            //Continue checking the rest of the word by increasing indexes together
                            if (ParallelMatchCheck(phrase, word, pi, wi).isMatch)
                            {
                                // Add matched word to list of matched words
                                match = ParallelMatchCheck(phrase, word, pi, wi);
                                // Add a GOTO HERE to exit loop and stop it from adding lip 3 times
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
            MatchedWord match = new MatchedWord(word);
            match.isMatch = true;

            if(phrase.Count - phraseIndex > word.Count - wordIndex)
            {
                // Word is shorter than phrase so check to end of word and the remainder of word will have -1 indexes. Leading or trailing? Decide on terminology.
                // This doesn't need to add -1s anywhere because if it doesn't match entirely to the end of the word, it is not a match.
                // I THINK THIS IS CORRECT
                for (int i = 1; i < word.Count - wordIndex; i++)
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
            return phrase.SequenceEqual(word);
        }

        private void GetPhraseIPAList()
        {
            string concat = String.Concat(WordsIPAList);
            List<string> listOfCharsIPA = new List<string>();

            //check first char,
            //if first char is equal to any one of the "double char" chars then check next char
            //if next char is equal to second one of "double chars" then treat that double char as single char and act accordingly
            //add to array, remove from concat

            while (concat.Length > 0)
            {
                // find all chars that match the start of concat
                var query = from c in aipa.ipaChars
                            where concat.StartsWith(c.character)
                            select c;

                var charMatches = query.ToList();
                
                
                if (charMatches.Count > 1)
                {
                    string largerMatch;
                    int lengthToRemove;

                    if (charMatches[0].character.Length > charMatches[1].character.Length)
                    {
                        largerMatch = charMatches[0].character;
                        lengthToRemove = charMatches[0].charLength;
                    }
                    else
                    {
                        largerMatch = charMatches[1].character;
                        lengthToRemove = charMatches[1].charLength;
                    }
                                        
                    listOfCharsIPA.Add(largerMatch);

                    concat = concat.Remove(0, lengthToRemove);

                }
                else
                {

                    listOfCharsIPA.Add(charMatches[0].character);

                    concat = concat.Remove(0, charMatches[0].charLength);
                }

            }

            PhraseIPAList = listOfCharsIPA;
            
        }

        
    }
}
