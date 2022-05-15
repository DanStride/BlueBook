using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class Result
    {
        public List<MatchedWord> result { get; set; }

        public bool isCompleteResult;

        public Result(Stack<MatchedWord> res)
        {
            result = new List<MatchedWord>();

            foreach (var item in res)
            {
                result.Add(item);
            }

            result.Reverse();
        }

        public Result(MatchedWord res)
        {

            result = new List<MatchedWord>();

            result.Add(res);
        }

        public override string ToString()
        {
            string resultString = "";

            foreach (var item in result)
            {
                resultString = $"{resultString} {item.Word.english}";
            }

            return resultString;
        }
    }
}
