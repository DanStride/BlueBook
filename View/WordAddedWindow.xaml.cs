using BlueBook.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Threading;

namespace BlueBook.View
{
    /// <summary>
    /// Interaction logic for OneSecondMessageWindow.xaml
    /// </summary>
    public partial class OneSecondMessageWindow : Window
    {
        public WordAddedWindowViewModel _vm;

        public delegate void ClickOption(string option);
        public event ClickOption OnClickOption;

        public OneSecondMessageWindow(WordAddedWindowViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            this.DataContext = _vm;
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            OnClickOption("done");
            this.Close();
        }

        private void anotherButton_Click(object sender, RoutedEventArgs e)
        {
            OnClickOption("another");
            this.Close();
        }
    }
}
