using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class AddWordCommand : ICommand
    {
        public AddWordWindowViewModel VM { get; set; }
        // TODO: Get a list of any missing words from entered phrase and pass it into here to auto-populate

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddWordCommand(AddWordWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            if (VM.NewWord != null && VM.NewWordIPAString != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            VM.AddNewWordToDataBase();
        }
    }
}
