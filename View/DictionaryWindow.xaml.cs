using BlueBook.Helpers;
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
    /// Interaction logic for DictionaryWindow.xaml
    /// </summary>
    public partial class DictionaryWindow : Window
    {
        public DictionaryWindowViewModel _vm;
        public DictionaryWindow()
        {
            InitializeComponent();
            _vm = new DictionaryWindowViewModel();
            this.DataContext = _vm;
        }

        private void createDbButton_Click(object sender, RoutedEventArgs e)
        {
            //DictionaryHelper dh = new DictionaryHelper();
            //dh.AddWordsToDB();
        }

        private void createAlphabetDB_Click(object sender, RoutedEventArgs e)
        {
            DictionaryHelper dh = new DictionaryHelper();
            dh.BuildAlphabetDB();
        }
    }
}
