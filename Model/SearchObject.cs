using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class SearchObject
    {
        public Dictionary<string, bool> _selections;
        public string _phrase;

        public SearchObject(Dictionary<string, bool> selections, string phrase)
        {
            _selections = selections;
            _phrase = phrase;
        }
    }
}
