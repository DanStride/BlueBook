using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class AddWordCharacterSelectCommand : ICommand
    {
        public AddWordWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddWordCharacterSelectCommand(AddWordWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() != "backspace")
            {
                VM.AddIPACharToNewWord(parameter.ToString());
            }
            else if (parameter.ToString() == "backspace")
            {
                VM.BackspaceLastChar();
            }
        }
    }
}
