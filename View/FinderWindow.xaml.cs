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
            enteredPhraseTextBox.Focus();
        }


        //private void tempButton_Click(object sender, RoutedEventArgs e)
        //{

        //    Encoding utf16 = Encoding.Unicode;

        //    using (StreamWriter sr = new StreamWriter("C:\\Users\\DAN\\Desktop\\CharacterDetail.txt"))
        //    {
        //        foreach (var character in IPAlphabet.ipaChars)
        //        {
        //            byte[] wordBytes = utf16.GetBytes(character.character);

        //            string byteString = "";

        //            for (int i = 0; i < wordBytes.Length; i++)
        //            {
        //                if (i == 0)
        //                {
        //                    byteString = $"{wordBytes[i].ToString()}";
        //                }
        //                else
        //                {
        //                    byteString = $"{byteString}, {wordBytes[i].ToString()}";
        //                }
        //            }

        //            sr.WriteLine($"Char: {character.character}");
        //            sr.WriteLine($"unicodeBytesAsIntList = {{ {byteString} }},");
        //            sr.WriteLine($"CharId: {character.charId}");
        //            sr.WriteLine($"CharLength: {character.charLength}");
        //            sr.WriteLine($"CharType: {character.characterType}");
        //            sr.WriteLine($"VowelType: {character.vowelType}");
        //            sr.WriteLine($"VowelHeight: {character.vowelHeight}");
        //            sr.WriteLine($"VowelBackness: {character.vowelBackness}");
        //            sr.WriteLine($"VowelRoundedness: {character.vowelRoundedness}");
        //            sr.WriteLine($"ConsonantVoicing: {character.consonantVoicing}");
        //            sr.WriteLine($"ConsonantPlaceOfArticulation: {character.consonantPlaceOfArticulation}");
        //            sr.WriteLine($"ConsonantMannerOfArticulation: {character.consonantMannerOfArticulation}");
        //            sr.WriteLine("-");
        //        }
        //    }


        //}
    }
}
