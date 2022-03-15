using BlueBook.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class ShowAddWordWindowCommand : ICommand
    {
        public FinderWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public ShowAddWordWindowCommand(FinderWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddWordWindow addWordWindow = new AddWordWindow();
            addWordWindow.Show();
        }
    }
}
