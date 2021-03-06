using BlueBook.Model;
using BlueBook.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using System.Timers;

namespace BlueBook.ViewModel.Commands
{
    public class AddWordCommand : ICommand
    {
        public AddWordWindowViewModel VM { get; set; }
        private DataRepo _dr;

        public delegate void ClickOption(string option);
        public event ClickOption OnClickOption;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddWordCommand(AddWordWindowViewModel vm)
        {
            VM = vm;
            _dr = new DataRepo();
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
            if (_dr.VerifyExistenceOfWord(VM.NewWord))
            {
                DisplayMessage($"{VM.NewWord} already exists in database.");
            }
            else
            {
                VM.AddNewWordToDataBase();
                DisplayMessage($"{VM.NewWord} was added succesfully");
            }
        }

        private void DisplayMessage(string message)
        {
            WordAddedWindowViewModel messageWindowVM = new WordAddedWindowViewModel(message);
            OneSecondMessageWindow messageWindow = new OneSecondMessageWindow(messageWindowVM);

            messageWindow.OnClickOption += MessageWindow_OnClickOption;

            messageWindow.Show();
            
        }

        private void MessageWindow_OnClickOption(string option)
        {
            OnClickOption(option);
        }
    }
}
