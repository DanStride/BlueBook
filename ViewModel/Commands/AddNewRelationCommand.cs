using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlueBook.ViewModel.Commands
{
    public class AddNewRelationCommand : ICommand
    {
        public DictionaryWindowViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddNewRelationCommand(DictionaryWindowViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            // Check That Data is correctly input
            // Check that both words exist (this is done in the execute method)
            return true;
        }

        public void Execute(object parameter)
        {
            DataRepo dr = new DataRepo();
            dr.InsertDictionaryRelation(dr.BuildDictionaryRelationsObject(VM.PrimaryWord, VM.SecondaryWord, VM.PrimarySubString, VM.SecondarySubString));
        }
    }
}
