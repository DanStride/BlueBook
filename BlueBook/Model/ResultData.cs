using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class ResultData
    {
        public Stack<MatchedWord> CurrentStack;
        public List<Result> Results;
        public List<MatchedWord> MatchedWords;
        public List<MatchedWord> ZeroList;
        public List<Result> LeadingWords;
        public int currentIndex;
        public int PhraseLength;

        public ResultData()
        {
            CurrentStack = new Stack<MatchedWord>();
            Results = new List<Result>();
            MatchedWords = new List<MatchedWord>();
            ZeroList = new List<MatchedWord>();
            LeadingWords = new List<Result>();
            currentIndex = 0;
            PhraseLength = 0;
        }
    }
}
