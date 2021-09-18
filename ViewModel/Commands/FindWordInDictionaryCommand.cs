using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class FindWordInDictionaryCommand : ICommand
    {
        public DictionaryWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public FindWordInDictionaryCommand(DictionaryWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.SearchForWord();
        }
    }
}
