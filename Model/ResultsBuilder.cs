using BlueBook.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueBook.Model
{
    public class ResultsBuilder
    {
        private int finalIndex;

        DataRepo _dr;

        private List<DictionaryIPA> dbList = new List<DictionaryIPA>();

        private List<MatchedWord> matchedWords = new List<MatchedWord>();
        public List<MatchedWord> MatchedWords
        {
            get { return matchedWords; }
            set { matchedWords = value; }
        }

        private List<Result> results;

        public List<Result> Results
        {
            get { return results; }
            set { results = value; }
        }

        private List<MatchedWord> zeroList;

        public List<MatchedWord> ZeroList
        {
            get { return zeroList; }
            set { zeroList = value; }
        }

        public string phraseInIPA { get; set; }


        public ResultsBuilder(List<MatchedWord> matches, int finIndex, string phrase)
        {
            MatchedWords = matches;
            finalIndex = finIndex;
            //CurrentResult = new Result();
            ZeroList = new List<MatchedWord>();
            Results = new List<Result>();
            CurrentStack = new Stack<MatchedWord>();
            StackIterator = new Stack<List<MatchedWord>>();
            LeadingWords = new List<Result>();
            phraseInIPA = phrase;
            ipaCharList = new List<DictionaryIPA>();
            //WorkingStack = new Stack<IPABytePair>();
            
        }

        public ResultsBuilder(List<DictionaryIPA> phrase)
        {
            ipaCharList = phrase;
            _dr = new DataRepo();
            dbList = _dr.GetEntireDictionaryIPAList();
        }

        private List<DictionaryIPA> ipaCharList;

        private Stack<MatchedWord> currentStack;

        public Stack<MatchedWord> CurrentStack
        {
            get { return currentStack; }
            set { currentStack = value; }
        }

        private Stack<List<MatchedWord>> stackIterator;

        public Stack<List<MatchedWord>> StackIterator
        {
            get { return stackIterator; }
            set { stackIterator = value; }
        }

        private List<Result> leadingWords;

        public List<Result> LeadingWords
        {
            get { return leadingWords; }
            set { leadingWords = value; }
        }

        int currentIndex = 0;


        int recursionDepth;

        public List<Result> GetLeadingWords()
        {
            return LeadingWords;
        }

        public void RemoveLeadingWords()
        {
            for (int i = 0; i < MatchedWords.Count; i++)
            {
                if (MatchedWords[i].Indexing[0] == -1)
                {
                    MatchedWords.RemoveAt(i);
                    i--;
                }
            }
        }

        int timesFindNextWordCalled;

        public Stack<int> FindNextWordIterationTracker = new Stack<int>();


        public List<Result> BuildResults()
        {
            

            // Separate leading words from matchlist where word contains only one matching final index of 0
            for (int i = 0; i < MatchedWords.Count; i++)
            {
                
                    // Check if the final index element of the current word is 0
                    if (MatchedWords[i].Indexing[MatchedWords[i].Indexing.Count - 1] == 0)
                {
                    bool hasOtherIndex = false;

                    // Check every index element of the current matched word except for the very last element (which should be 0)
                    for (int p = 0; p < MatchedWords[i].Indexing.Count - 1; p++)
                    {
                        // Check if the index element is -1 (not matching) 
                        if (MatchedWords[i].Indexing[p] != -1)
                        {
                            hasOtherIndex = true;
                        }
                    }

                    // Confirmed single match leading word. Add to leading word list. Remove from matchedwords. Set loop index back by 1 to compensate for removing an element. 
                    if (!hasOtherIndex)
                    {
                        LeadingWords.Add(new Result(MatchedWords[i]));
                        MatchedWords.RemoveAt(i);
                        i--;
                    }

                }
            }

            // Add one leading word back to MatchedWords so that no matches are missed.
            if (LeadingWords.Count > 0) MatchedWords.Add(LeadingWords[0].result[0]);


            // Build list of all words with a 0
            for (int i = 0; i < MatchedWords.Count; i++)
            {
                if (MatchedWords[i].Indexing.Contains(0))
                {
                    ZeroList.Add(MatchedWords[i]);
                }
            }

            // Iterate Zero list and add results
            for (int i = 0; i < ZeroList.Count; i++)
            {
                //CurrentStack.Push(ZeroList[i]);

                //int listDepth = 0;

                //ListFollowList.Add(new FollowingWordListChecker(MatchedWords, 0, finalIndex));





                //do
                //{
                //    foreach (var item in ListFollowList[listDepth].CompleteResults)
                //    {
                //        CurrentStack.Push(item);
                //        AddCurrentResult();
                //        CurrentStack.Pop();
                //    }

                //    if (ListFollowList[listDepth].FollowingWords.Count > 0)
                //    {
                //        for (int fwordsI = 0; fwordsI < ListFollowList[listDepth].FollowingWords.Count; fwordsI++)
                //        {
                //            CurrentStack.Push(ListFollowList[listDepth].FollowingWords[fwordsI]);

                //            int newCurrentIndex = ListFollowList[0].FollowingWords[i].Indexing.Max() + 1;

                //            ListFollowList.Add(new FollowingWordListChecker(MatchedWords, newCurrentIndex, finalIndex));

                //            listDepth++;
                //        }
                //    }

                //} while (ListFollowList[listDepth].FollowingWords.Count > 0);


                //{
                //    // Finish and go to nect zero list item
                //}




                recursionDepth = 0;

                //CurrentStack.Clear();

                CurrentStack.Push(ZeroList[i]);

                // If element does not contain the final index, find the next words to complete the result
                if (!ZeroList[i].Indexing.Contains(finalIndex))
                {
                    currentIndex = GetHighestIndexFromCurrentStack();

                    recursionDepth++;

                    if (FindNextWord(true))
                    {
                        CurrentStack.Pop();

                        currentIndex = GetHighestIndexFromCurrentStack();

                        recursionDepth--;
                    }

                    
                }
                else if (ZeroList[i].Indexing.Contains(finalIndex))
                {
                    AddCurrentResult();
                    CurrentStack.Pop();

                    currentIndex = GetHighestIndexFromCurrentStack();
                }

            }


            return Results;
        }


        private bool CheckIfSingleCharWord(MatchedWord match)
        {
            bool isSingleOrDoubleChar;

            if (match.Indexing.Count >= 1) isSingleOrDoubleChar = true;
            else isSingleOrDoubleChar = false;

            return isSingleOrDoubleChar;
        }


        private void AddCurrentResult()
        {
            Results.Add(new Result(CurrentStack));

        }

        private int GetFindNextWordIterationVariable()
        {
            int iterator = 0;

            int stackHeight = CurrentStack.Count - 1;

            if (FindNextWordIterationTracker.Count > 0)
            {
                iterator = FindNextWordIterationTracker.Pop() + 1;
            }
            else
            {
                iterator = 0;
            }

            return iterator;
        }


        private bool FindNextWord(bool startFromZero)
        {

            timesFindNextWordCalled++;

            int iterator = 0;

            if (!startFromZero)
            {
                iterator = GetFindNextWordIterationVariable();
            }



            for (int i = iterator; i < MatchedWords.Count; i++)
            {


                MatchedWord currentWord = MatchedWords[i];

                if (currentWord.Word.english == "ounces")
                {

                }

                //if ((MatchedWords[i].Indexing[0] == currentIndex) && MatchedWords[i].Indexing.Contains(finalIndex))
                //{

                //    CurrentStack.Push(MatchedWords[i]);

                //    AddCurrentResult();

                //    CurrentStack.Pop();

                //    currentIndex = GetHighestIndexFromCurrentStack();

                //}
                //else if (MatchedWords[i].Indexing[0] == currentIndex && !MatchedWords[i].Indexing.Contains(finalIndex))
                //{
                //    CurrentStack.Push(MatchedWords[i]);

                //    recursionDepth++;

                //    currentIndex = GetHighestIndexFromCurrentStack();

                //    FindNextWordIterationTracker.Push(i);

                //    FindNextWord(true);
                //}

                // ADD THIS CODE BACK IN WHEN STACK OVERFLOW PROBLEM IS SOLVED

                if (!CheckIfSingleCharWord(MatchedWords[i]))
                {

                    if ((MatchedWords[i].Indexing[0] == currentIndex || MatchedWords[i].Indexing[0] == currentIndex - 1) && MatchedWords[i].Indexing.Contains(finalIndex))
                    {

                        CurrentStack.Push(MatchedWords[i]);

                        AddCurrentResult();

                        CurrentStack.Pop();

                        currentIndex = GetHighestIndexFromCurrentStack();

                    }
                    else if ((MatchedWords[i].Indexing[0] == currentIndex || MatchedWords[i].Indexing[0] == currentIndex - 1) && !MatchedWords[i].Indexing.Contains(finalIndex))
                    {
                        CurrentStack.Push(MatchedWords[i]);

                        recursionDepth++;

                        currentIndex = GetHighestIndexFromCurrentStack();

                        FindNextWordIterationTracker.Push(i);

                        FindNextWord(true);
                    }
                }
                else
                {
                    if ((MatchedWords[i].Indexing[0] == currentIndex) && MatchedWords[i].Indexing.Contains(finalIndex))
                    {

                        CurrentStack.Push(MatchedWords[i]);

                        AddCurrentResult();

                        CurrentStack.Pop();

                        currentIndex = GetHighestIndexFromCurrentStack();

                    }
                    else if (MatchedWords[i].Indexing[0] == currentIndex && !MatchedWords[i].Indexing.Contains(finalIndex))
                    {
                        CurrentStack.Push(MatchedWords[i]);

                        recursionDepth++;

                        currentIndex = GetHighestIndexFromCurrentStack();

                        FindNextWordIterationTracker.Push(i);

                        FindNextWord(true);
                    }
                }

            }

            if (CurrentStack.Count > 1)
            {
                

                CurrentStack.Pop();

                currentIndex = GetHighestIndexFromCurrentStack();

                recursionDepth--;

                //FindNextWord(false);
            }


            return true;
        }

        private int GetHighestIndexFromCurrentStack()
        {
            int highestIndex = 0;

            if (CurrentStack.Count > 0)
            {
                MatchedWord peek = CurrentStack.Peek();

                highestIndex = peek.Indexing[peek.Indexing.Count - 1] + 1; // ( +1, -1)
            }


            //// What if its has a double match in there?
            //foreach (var item in stack)
            //{
            //    for (int i = 0; i < item.Indexing.Count; i++)
            //    {
            //        if (item.Indexing[i] != -1) highestIndex++;
            //    }
            //}

            return highestIndex;
        }

        //private void GetStackIndex()
        //{
        //    if (CurrentStack.Count > 0)
        //    {
        //        var index = CurrentStack.Peek();

        //        stackIndex = index.Indexing[index.Indexing.Count - 1];
        //    }
        //    else
        //    {
        //        stackIndex = 0;
        //    }
        //}

        //public List<Result> MatchAndBuildResults()
        //{
        //    // Set phraseIPAString and phraseByteList

        //    dbBytePairs = IPAStringHelper.GetListOfIPABytePairFromListOfDictionaryIPA(dbList);
        //    string phraseIPAString = IPAStringHelper.GetIPAStringFromDictionaryIPAList(ipaCharList);
        //    Results = new List<Result>();
        //    //WorkingStack = new Stack<IPABytePair>();

        //    List<byte[]> phraseByteList = IPAStringHelper.GetByteListFromString(phraseIPAString);
        //    endOfPhraseIndex = phraseByteList.Count - 1;



        //    List<IPABytePair> zeroBytePairs = new List<IPABytePair>();

        //    for (int i = 0; i < dbBytePairs.Count; i++)
        //    {
        //        FindAndBuildResults(phraseByteList, dbBytePairs[i]);

        //    }

        //    return results;
        //}

        //private void FindAndBuildResults(List<byte[]> phraseBytes, IPABytePair dbBytes)
        //{

        //    bool isLeadingWord = true;

        //    GetStackIndex();

        //    if (stackIndex > 0) isLeadingWord = false;


        //    for (int i = 0; i < dbBytes.Bytes.Count; i++)
        //    {
        //        // If the index of the word is not at zero, it MUST be a leading word. 
        //        if (isLeadingWord = true && i != 0)
        //        {
        //            // If we are at the first index of the word, and it does not return a match, it MUST be either leading word or not a match.
        //            // To qualify as a leading word it will need to match the first index of the phrase somewhere, and either A: match all the way to the end of the word, or B: match all the way until the end of the phrase (which makes it both leading AND trailing)
        //            if (BytesMatch(phraseBytes[0], dbBytes.Bytes[i]))
        //            {
        //                // A: match all the way to the end of the word

        //                int remainderOfPhrase = phraseBytes.Count;
        //                int remainderOfWord = dbBytes.Bytes.Count - i;


        //                if (remainderOfPhrase > remainderOfWord)
        //                {
        //                    if (ParallelMatchCheck(phraseBytes, dbBytes.Bytes, 0, i))
        //                    {
        //                        // Will need recursion here
        //                        WorkingStack.Push(dbBytes);
        //                        RecursiveMatchFinder(phraseBytes);

        //                    }
        //                }

        //                // B: match all the way until the end of the phrase
        //                else
        //                {
        //                    if (ParallelMatchCheck(phraseBytes, dbBytes.Bytes, 0, i))
        //                    {
        //                        // Will not need recursion here
        //                        WorkingStack.Push(dbBytes);
        //                        AddResultToListAndPop();
        //                        WorkingStack.Pop();
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        // Doesn't NEED to be a leading word, can run standard match algorithm
        //        {
        //            RecursiveMatchFinder(phraseBytes);
        //        }
        //    }
        //}

        //private void RecursiveMatchFinder(List<byte[]> phraseBytes)
        //{
        //    // This no longer needs to deal with leading words, therefore a match must be made of the first index of the word with the currentStackIndex+1

        //    GetStackIndex();
        //    int startIndexOfPhrase = stackIndex;

        //    // Get the current word
        //    for (int currentWord = 0; currentWord < dbBytePairs.Count; currentWord++)
        //    {
        //        // Start iteration on the first index of the word
        //        for (int wordIndex = 0; wordIndex < dbBytePairs[currentWord].Bytes.Count; wordIndex++)
        //        {
        //            // Start iteration from wherever the stack left off
        //            for (int phraseIndex = startIndexOfPhrase; phraseIndex < phraseBytes.Count; phraseIndex++)
        //            {
        //                // Check if it matches anywhere
        //                if (BytesMatch(phraseBytes[phraseIndex], dbBytePairs[currentWord].Bytes[wordIndex]))
        //                {
        //                    // If it does, check to the end of the word
        //                    if (ParallelMatchCheck(phraseBytes, dbBytePairs[currentWord].Bytes, startIndexOfPhrase + phraseIndex, wordIndex))
        //                    {
        //                        WorkingStack.Push(dbBytePairs[currentWord]);
        //                        GetStackIndex();

        //                        // Total stack index is greater than or equal to phrase, meaning it is a complete result
        //                        if (stackIndex + dbBytePairs[currentWord].Bytes.Count >= phraseBytes.Count)
        //                        {
        //                            AddResultToListAndPop();
        //                            WorkingStack.Pop();
        //                            GetStackIndex();

        //                        }
        //                        // Result is still incomplete
        //                        else
        //                        {
        //                            RecursiveMatchFinder(phraseBytes);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private bool ParallelMatchCheck(List<byte[]> phraseBytes, List<byte[]> wordBytes, int phraseIndex, int wordIndex)
        //{
        //    bool isMatch = true;

        //    // A: match all the way to the end of the word
        //    if (phraseBytes.Count - phraseIndex > wordBytes.Count - wordIndex)
        //    {
        //        for (int i = 0; i < wordBytes.Count - wordIndex; i++)
        //        {
        //            if (!BytesMatch(phraseBytes[phraseIndex + i], wordBytes[wordIndex + i]))
        //            {
        //                // If there is no match before reaching the end of the word, it is not a match
        //                isMatch = false;
        //                break;
        //            }
        //            else
        //            {
        //                // Add to stack
        //            }
        //        }
        //    }

        //    // B: match all the way until the end of the phrase
        //    else
        //    {
        //        for (int i = 0; i < phraseBytes.Count - phraseIndex; i++)
        //        {
        //            if (!BytesMatch(phraseBytes[phraseIndex + i], wordBytes[wordIndex + i]))
        //            {

        //            }
        //            if (!BytesMatch(phraseBytes[phraseIndex + i], wordBytes[wordIndex + i]))
        //            {
        //                // If there is no match before reaching the end of the word, it is not a match
        //                isMatch = false;
        //                break;
        //            }
        //            else
        //            {
        //                // Add to stack
        //                // Call method to check for next word
        //            }
        //        }
        //    }

        //    return isMatch;
        //}

        //private bool BytesMatch(byte[] phraseBytes, byte[] wordBytes)
        //{
        //    bool byteMatch = false;

        //    byteMatch = phraseBytes.SequenceEqual(wordBytes);

        //    return byteMatch;
        //}
    }
}
