using BlueBook.Model;
using BlueBook.Static_Classes;
using BlueBook.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Serilog;


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

            string logPath = $"{Directory.GetCurrentDirectory()}\\logs\\logs.txt";

            if (File.Exists(logPath)) File.Delete(logPath);
            

                Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(logPath)
                .CreateLogger();

            Log.Information("Application Start");

            _vm = new FinderWindowViewModel();
            this.DataContext = _vm;
            enteredPhraseTextBox.Focus();
        }
    }
}
