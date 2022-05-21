using BlueBook.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlueBook.View
{
    /// <summary>
    /// Interaction logic for AddWordWindow.xaml
    /// </summary>
    public partial class AddWordWindow : Window
    {
        public AddWordWindowViewModel _vm;
        public AddWordWindow()
        {
            InitializeComponent();
            _vm = new AddWordWindowViewModel();
            _vm.OnClickOption += _vm_OnClickOption;
            this.DataContext = _vm;
            wordToAddTextBox.Focus();
        }

        private void _vm_OnClickOption(string option)
        {
            if (option == "done")
            {
                this.Close();
            }
            else if (option == "another")
            {
                _vm.IpaChars.Clear();
                _vm.NewWordIPAList.Clear();
                _vm.NewWord = "";
                _vm.CharString = "";
                _vm.NewWordIPAString = "";
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
                
            }
        }
    }
}
