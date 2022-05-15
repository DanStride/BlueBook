using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.ViewModel
{
    public class OneSecondMessageWindowViewModel
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public OneSecondMessageWindowViewModel(string message)
        {
            Message = message;
        }
    }
}
