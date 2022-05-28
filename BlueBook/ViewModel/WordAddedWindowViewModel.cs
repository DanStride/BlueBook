using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.ViewModel
{
    public class WordAddedWindowViewModel
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public WordAddedWindowViewModel(string message)
        {
            Message = message;
        }
    }
}
