using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class FollowingWordListChecker
    {
        public List<MatchedWord> MatchedWords;
        public List<MatchedWord> FollowingWords;
        public List<MatchedWord> CompleteResults;
        int CurrentIndex;
        int FinalIndex;

        public FollowingWordListChecker(List<MatchedWord> matches, int cIndex, int fIndex)
        {
            MatchedWords = matches;
            CurrentIndex = cIndex;
            FinalIndex = fIndex;

            FollowingWords = new List<MatchedWord>();
            CompleteResults = new List<MatchedWord>();

            for (int i = 0; i < MatchedWords.Count; i++)
            {
                if (CheckIfSingleCharWord(MatchedWords[i]))
                {
                    if(MatchedWords[i].Indexing[0] == CurrentIndex || MatchedWords[i].Indexing[0] == CurrentIndex - 1 && MatchedWords[i].Indexing.Contains(FinalIndex))
                    {
                        CompleteResults.Add(MatchedWords[i]);
                    }
                    else if (MatchedWords[i].Indexing[0] == CurrentIndex || MatchedWords[i].Indexing[0] == CurrentIndex - 1 && !MatchedWords[i].Indexing.Contains(FinalIndex))
                    {
                        FollowingWords.Add(MatchedWords[i]);
                    }
                }
                else
                {
                    if (MatchedWords[i].Indexing[0] == CurrentIndex && MatchedWords[i].Indexing.Contains(FinalIndex))
                    {
                        CompleteResults.Add(MatchedWords[i]);
                    }
                    else if (MatchedWords[i].Indexing[0] == CurrentIndex && !MatchedWords[i].Indexing.Contains(FinalIndex))
                    {
                        FollowingWords.Add(MatchedWords[i]);
                    }
                }

            }
        }

        private bool CheckIfSingleCharWord(MatchedWord match)
        {
            bool isSingleChar;

            if (match.Indexing.Count == 1) isSingleChar = true;
            else isSingleChar = false;

            return isSingleChar;
        }
    }
}
