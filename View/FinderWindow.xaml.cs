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
    /// Interaction logic for FinderWindow.xaml
    /// </summary>
    public partial class FinderWindow : Window
    {
        public FinderWindowViewModel _vm;
        public FinderWindow()
        {
            InitializeComponent();
            _vm = new FinderWindowViewModel();
            this.DataContext = _vm;
        }
    }
}
