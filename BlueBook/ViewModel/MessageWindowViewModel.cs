using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.ViewModel
{
    public class MessageWindowViewModel
    {
        
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private List<string> missingWords;

        public List<string> MissingWords
        {
            get { return missingWords; }
            set { missingWords = value; }
        }

        public MessageWindowViewModel(List<string> missingWords)
        {
            // This constructor builds a Messagebox for missing words
            MissingWords = missingWords;
            Message = "The following words could not be found:";
        }

    }
}
