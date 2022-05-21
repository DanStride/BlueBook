using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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

        private int recursionDepth;

        public int RecursionDepth
        {
            get { return recursionDepth; }
            set { recursionDepth = value; }
        }

        public delegate void ProgressUpdate(int value);
        public event ProgressUpdate OnProgressUpdate;

        public void UpdateProgress(float index, float zeroListCount)
        {
            float valueFloat = (index / zeroListCount) * 100;

            int value = (int)Math.Round(valueFloat);
            OnProgressUpdate(value);
        }

        public ResultData BuildResults(List<MatchedWord> matches, int finalIndex)
        {
            ResultData resultData = new ResultData();
            FindNextWordIterationTracker = new Stack<int>();

            resultData.MatchedWords = matches;
            resultData.FinalIndex = finalIndex;           


            for (int i = 0; i < resultData.MatchedWords.Count; i++)
            {
                if (resultData.MatchedWords[i].Indexing[resultData.MatchedWords[i].Indexing.Count - 1] == 0)
                {
                    bool hasOtherIndex = false;

                    for (int p = 0; p < resultData.MatchedWords[i].Indexing.Count - 1; p++)
                    {
                        if (resultData.MatchedWords[i].Indexing[p] != -1)
                        {
                            hasOtherIndex = true;
                        }
                    }
                    if (!hasOtherIndex)
                    {
                        resultData.LeadingWords.Add(new Result(resultData.MatchedWords[i]));
                        resultData.MatchedWords.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (resultData.LeadingWords.Count > 0) resultData.MatchedWords.Add(resultData.LeadingWords[0].result[0]);

            for (int i = 0; i < resultData.MatchedWords.Count; i++)
            {
                if (resultData.MatchedWords[i].Indexing.Contains(0))
                {
                    resultData.ZeroList.Add(resultData.MatchedWords[i]);
                }
            }
            for (int i = 0; i < resultData.ZeroList.Count; i++)
            {
                UpdateProgress(i, resultData.ZeroList.Count);

                int recursionDepth = 0;
                resultData.CurrentStack.Push(resultData.ZeroList[i]);

                if (!resultData.ZeroList[i].Indexing.Contains(finalIndex))
                {
                    resultData.currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                    recursionDepth++;

                    if (FindNextWord(true, resultData))
                    {
                        resultData.CurrentStack.Pop();
                        resultData.currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                        recursionDepth--;
                    }

                }
                else if (resultData.ZeroList[i].Indexing.Contains(finalIndex))
                {
                    resultData = AddCurrentResult(resultData);
                    resultData.CurrentStack.Pop();
                    resultData.currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                }

            }

            return resultData;
        }

        private int GetHighestIndexFromCurrentStack(Stack<MatchedWord> currentStack)
        {
            int highestIndex = 0;

            if (currentStack.Count > 0)
            {
                MatchedWord peek = currentStack.Peek();

                highestIndex = peek.Indexing[peek.Indexing.Count - 1] + 1;
            }
            return highestIndex;
        }

        private bool FindNextWord(bool startFromZero, ResultData resultData)
        {
            int iterator = 0;
            int currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);

            if (!startFromZero)
            {
                iterator = GetFindNextWordIterationVariable(resultData.CurrentStack);
            }

            for (int i = iterator; i < resultData.MatchedWords.Count; i++)
            {
                MatchedWord currentWord = resultData.MatchedWords[i];

                if (!CheckIfSingleCharWord(resultData.MatchedWords[i]))
                {

                    if ((resultData.MatchedWords[i].Indexing[0] == currentIndex || resultData.MatchedWords[i].Indexing[0] == currentIndex - 1) && resultData.MatchedWords[i].Indexing.Contains(resultData.FinalIndex))
                    {
                        resultData.CurrentStack.Push(resultData.MatchedWords[i]);
                        resultData = AddCurrentResult(resultData);
                        resultData.CurrentStack.Pop();
                        currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                    }
                    else if ((resultData.MatchedWords[i].Indexing[0] == currentIndex || resultData.MatchedWords[i].Indexing[0] == currentIndex - 1) && !resultData.MatchedWords[i].Indexing.Contains(resultData.FinalIndex))
                    {
                        resultData.CurrentStack.Push(resultData.MatchedWords[i]);
                        RecursionDepth++;
                        currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                        FindNextWordIterationTracker.Push(i);
                        ResultData newData = new ResultData();
                        FindNextWord(true, newData);
                    }
                }
                else
                {
                    if ((resultData.MatchedWords[i].Indexing[0] == currentIndex) && resultData.MatchedWords[i].Indexing.Contains(resultData.FinalIndex))
                    {
                        resultData.CurrentStack.Push(resultData.MatchedWords[i]);
                        resultData = AddCurrentResult(resultData);
                        resultData.CurrentStack.Pop();
                        currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                    }
                    else if (resultData.MatchedWords[i].Indexing[0] == currentIndex && !resultData.MatchedWords[i].Indexing.Contains(resultData.FinalIndex))
                    {
                        resultData.CurrentStack.Push(resultData.MatchedWords[i]);
                        RecursionDepth++;
                        currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                        FindNextWordIterationTracker.Push(i);
                        ResultData newData = new ResultData();
                        FindNextWord(true, newData);
                    }
                }
            }

            if (resultData.CurrentStack.Count > 1)
            {
                resultData.CurrentStack.Pop();
                currentIndex = GetHighestIndexFromCurrentStack(resultData.CurrentStack);
                recursionDepth--;
            }


            return true;
        }

        private int GetFindNextWordIterationVariable(Stack<MatchedWord> currentStack)
        {
            int iterator = 0;

            int stackHeight = currentStack.Count - 1;

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

        private ResultData AddCurrentResult(ResultData resultData)
        {
            ResultData newData = resultData;
            newData.Results.Add(new Result(resultData.CurrentStack));
            return newData;
        }

        private bool CheckIfSingleCharWord(MatchedWord match)
        {
            bool isSingleOrDoubleChar;

            if (match.Indexing.Count >= 1) isSingleOrDoubleChar = true;
            else isSingleOrDoubleChar = false;

            return isSingleOrDoubleChar;
        }
    }
}
