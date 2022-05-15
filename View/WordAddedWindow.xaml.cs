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
        public OneSecondMessageWindowViewModel _vm;

        public OneSecondMessageWindow(OneSecondMessageWindowViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            this.DataContext = _vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
