using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Serilog;

namespace BlueBook.Logic
{
    public class ResultBuilder
    {

        private Stack<int> findNextWordIterationTracker;

        public Stack<int> FindNextWordIterationTracker
        {
            get { return findNextWordIterationTracker; }
            set { findNextWordIterationTracker = value; }
        }

        private Stack<MatchedWord> resultStack;

        public Stack<MatchedWord> ResultStack
        {
            get { return resultStack; }
            set { resultStack = value; }
        }

        private List<Result> results;

        public List<Result> Results
        {
            get { return results; }
            set { results = value; }
        }


        private int recursionDepth;

        public int RecursionDepth
        {
            get { return recursionDepth; }
            set { recursionDepth = value; }
        }

        private ResultData resultData;

        

        public delegate void ProgressUpdate(int value);
        public event ProgressUpdate OnProgressUpdate;

        public ResultBuilder(List<DictionaryIPA> phrase)
        {
            Results = new List<Result>();
            ResultStack = new Stack<MatchedWord>();
            resultData = new ResultData();
        }

        public void UpdateProgress(float index, float zeroListCount)
        {
            float valueFloat = (index / zeroListCount) * 100;

            int value = (int)Math.Round(valueFloat);
            OnProgressUpdate(value);
        }

        public ResultData BuildResults(List<MatchedWord> matches, int phraseLength)
        {
            Log.Logger.Information("START BuildResults()");

            
            FindNextWordIterationTracker = new Stack<int>();
            recursionDepth = 0;

            resultData.MatchedWords = matches;
            resultData.PhraseLength = phraseLength;

            resultData = SeparateLeadingWordsFromMatchedWords(resultData);
            resultData = GetZeroList(resultData);


            Log.Logger.Information($"MatchedWords Count: {resultData.MatchedWords.Count}");
            Log.Logger.Information($"ZeroList Count: {resultData.ZeroList.Count}");
        
            // Iterating over the list of leading words (zerolist)
            for (int i = 0; i < resultData.ZeroList.Count; i++)
            {
                Log.Logger.Information($"ZeroList item {i + 1} of {resultData.ZeroList.Count}");
                UpdateProgress(i, resultData.ZeroList.Count);

                if(ResultStack.Count > 0) Log.Logger.Error("CURRENT STACK SHOULD BE 0!");

                // Add the first word to the stack
                ResultStack.Push(resultData.ZeroList[i]);

                // If the word doesn't contains the final index
                if (!resultData.ZeroList[i].Indexing.Contains(phraseLength))
                {
                    FindNextWordRecursive();

                    Log.Logger.Information($"FINISHED: {ResultStack.Peek()}.");
                    Log.Logger.Information($"Stack Height: {ResultStack.Count}");
                    ResultStack.Pop();
                }
                // If the word is longer than the remainder of the phrase, it's a complete SINGLE WORD result
                else if (resultData.ZeroList[i].Indexing.Contains(phraseLength))
                {
                    Log.Logger.Information($"SINGLE WORD RESULT: {ResultStack.Peek()}, Height: {ResultStack.Count}");
                    Results.Add(new Result(ResultStack));
                    ResultStack.Pop();
                }
                else Log.Logger.Error("SOMETHING WENT WRONG!"); 

                if (resultData.CurrentStack.Count > 0) Log.Logger.Error("STACK IS NOT EMPTY");
            }
            resultData.Results = Results;
            Log.Logger.Information("END BuildResults()");
            return resultData;
        }

        private int GetValueOfTopItemsFinalIndex(Stack<MatchedWord> currentStack)
        {
            int highestIndex = 0;

            if (currentStack.Count > 0)
            {
                MatchedWord peek = currentStack.Peek();

                highestIndex = peek.Indexing[peek.Indexing.Count - 1] + 1;
            }
            return highestIndex;
        }

        private void FindNextWordRecursive()
        {
            recursionDepth++;

            Log.Logger.Information($"START FindNextWord(), now {recursionDepth} levels deep.");

            int currentIndex = GetValueOfTopItemsFinalIndex(ResultStack);

            for (int i = 0; i < resultData.MatchedWords.Count; i++)
            {
                // If this is not a single character word
                if (!CheckIfSingleCharWord(resultData.MatchedWords[i]))
                {
                        // It's a complete result
                        if ((resultData.MatchedWords[i].Indexing[0] == currentIndex || resultData.MatchedWords[i].Indexing[0] == currentIndex - 1) && resultData.MatchedWords[i].Indexing.Contains(resultData.PhraseLength))
                        {
                            ResultStack.Push(resultData.MatchedWords[i]);
                            Results.Add(new Result(ResultStack));
                            ResultStack.Pop();
                            currentIndex = GetValueOfTopItemsFinalIndex(ResultStack);
                        }
                        // Does not contain final index, not yet a complete result
                        else if ((resultData.MatchedWords[i].Indexing[0] == currentIndex || resultData.MatchedWords[i].Indexing[0] == currentIndex - 1) && !resultData.MatchedWords[i].Indexing.Contains(resultData.PhraseLength))
                        {
                            ResultStack.Push(resultData.MatchedWords[i]);
                            currentIndex = GetValueOfTopItemsFinalIndex(ResultStack);
                            FindNextWordRecursive();
                            ResultStack.Pop();
                        }
                        else Log.Logger.Error("NO MATCHES");

                }
                // If this is a single char word, we don't check the previous index as well in the conditional
                else
                {
                    // Complete result
                    if ((resultData.MatchedWords[i].Indexing[0] == currentIndex) && resultData.MatchedWords[i].Indexing.Contains(resultData.PhraseLength))
                    {
                            ResultStack.Push(resultData.MatchedWords[i]);
                            Results.Add(new Result(ResultStack));
                            ResultStack.Pop();
                            currentIndex = GetValueOfTopItemsFinalIndex(ResultStack);
                    }
                    // Incomplete result
                    else if (resultData.MatchedWords[i].Indexing[0] == currentIndex && !resultData.MatchedWords[i].Indexing.Contains(resultData.PhraseLength))
                    {
                            ResultStack.Push(resultData.MatchedWords[i]);
                            currentIndex = GetValueOfTopItemsFinalIndex(ResultStack);
                            FindNextWordRecursive();
                            ResultStack.Pop();
                    }
                }
            }

            recursionDepth--;
            Log.Logger.Information($"END FindNextWord(), now {recursionDepth} levels deep.");
        }

        private bool CheckIfSingleCharWord(MatchedWord match)
        {
            bool isSingleChar = match.Indexing.Count >= 1 ? true : false;
            return isSingleChar;
        }

        private ResultData SeparateLeadingWordsFromMatchedWords(ResultData resultData)
        {
            ResultData data = resultData;

            for (int i = 0; i < data.MatchedWords.Count; i++)
            {
                // If the first character of the phrase is found at the final index of the word
                if (data.MatchedWords[i].Indexing[data.MatchedWords[i].Indexing.Count - 1] == 0)
                {
                    bool hasOtherIndex = false;

                    // Check the rest of the word and see if the characters match all the way to end of the word or not
                    for (int p = 0; p < data.MatchedWords[i].Indexing.Count - 1; p++)
                    {

                        if (data.MatchedWords[i].Indexing[p] != -1)
                        {
                            hasOtherIndex = true;
                        }
                    }
                    // It matches all the way to the end, add to new list and remove from main matchedwords list (is this a good idea?)
                    if (!hasOtherIndex)
                    {
                        data.LeadingWords.Add(new Result(data.MatchedWords[i]));
                        data.MatchedWords.RemoveAt(i);
                        i--;
                    }
                }
            }

            // Add the first word from leading words to the end of the main matchedwords list
            if (data.LeadingWords.Count > 0) data.MatchedWords.Add(data.LeadingWords[0].result[0]);

            return data;
        }

        private ResultData GetZeroList(ResultData resultData)
        {
            ResultData data = resultData;

            for (int i = 0; i < data.MatchedWords.Count; i++)
            {
                if (data.MatchedWords[i].Indexing.Contains(0))
                {
                    data.ZeroList.Add(data.MatchedWords[i]);
                }
            }

            return data;
        }
    }
}
