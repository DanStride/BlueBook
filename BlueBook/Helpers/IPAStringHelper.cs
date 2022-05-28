using BlueBook.Model;
using BlueBook.Static_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace BlueBook.Helpers
{
    public static class IPAStringHelper
    {
        public static Encoding utf16 = Encoding.Unicode;

        public static string CleanIPA(this string line)
        {
            while (line.Contains("ˈ"))
            {
                int x = line.IndexOf("ˈ");
                line = line.Remove(x, 1);
            }
            while (line.Contains("ˌ"))
            {
                int x = line.IndexOf("ˌ");
                line = line.Remove(x, 1);
            }
            return line;
        }

        public static List<string> SplitWordsIntoList(string words)
        {
            return words.Split(" ").ToList();
        }

        public static List<string> GetStringListFromByteList(List<byte[]> bytes)
        {
            List<string> stringList = new List<string>();

            foreach (var byteset in bytes)
            {
                stringList.Add(utf16.GetString(byteset));
            }
            return stringList;
        }

        public static string GetStringFromByteArray(byte[] bytes)
        {
            string character = utf16.GetString(bytes);

            return character;
        }

        public static List<int> GetIntListFromByteArray(byte[] bytes)
        {
            List<int> newIntList = new List<int>();

            foreach (var b in bytes)
            {
                newIntList.Add(b);
            }

            return newIntList;
        }

        public static List<int> RemoveThirteenThirtyTwoFromBeginningOfIntList(List<int> intList)
        {
            List<int> newList = intList;

            if ((newList[0] == 13) && (newList[1] == 32))
            {
                newList.RemoveRange(0, 2);
            }

            return newList;
        }

        public static List<byte[]> RemoveThirteenThirtyTwoFromByteList(List<byte[]> byteList)
        {
            List<byte[]> newList = byteList;

            byte[] removeThisByte = { 13, 32 };

            for (int i = 0; i < newList.Count; i++)
            {
                if (byteList[i].SequenceEqual(removeThisByte))
                {
                    newList.RemoveAt(i);
                    i--;
                }
            }

            return newList;
        }

        public static bool ParallelByteCheck(int counter, List<int> alphabetChar, List<int> wordChar)
        {
            bool isMatch = true;

            for (int p = 0; p < counter; p++)
            {
                if (alphabetChar[p] != wordChar[p])
                {
                    isMatch = false;
                    break;
                }
            }

            return isMatch;
        }

        public static List<byte[]> GetByteListFromIPAString(string ipaString)
        {
            List<byte[]> finishedBytesInList = new List<byte[]>();
            byte [] ipaBytes = utf16.GetBytes(ipaString);
            List<int> tempIPABytesInList = GetIntListFromByteArray(ipaBytes);
            List<int> currentMatch = new List<int>();

            while (tempIPABytesInList.Count > 0)
            {
                bool isMatch = true;

                tempIPABytesInList = RemoveThirteenThirtyTwoFromBeginningOfIntList(tempIPABytesInList);

                var characterMatches = from c in IPAlphabet.ipaChars
                                       where c.unicodeBytesAsIntList[0] == tempIPABytesInList[0]
                                       orderby c.unicodeBytesAsIntList[0] descending
                                       select c;

                List<CharacterIPA> listCharIPA = characterMatches.ToList();


                if (listCharIPA.Count == 0)
                {
                    MessageBox.Show("Error: No characterMatches found!");
                }

                foreach (var match in characterMatches)
                {
                    if (match.unicodeBytesAsIntList.Count == 6 && tempIPABytesInList.Count >= 6)
                    {
                        if (isMatch = ParallelByteCheck(6, match.unicodeBytesAsIntList, tempIPABytesInList))
                        {
                            currentMatch = match.unicodeBytesAsIntList;
                            break;
                        }
                    }
                    else if (match.unicodeBytesAsIntList.Count == 4 && tempIPABytesInList.Count >= 4)
                    {
                        if (isMatch = ParallelByteCheck(4, match.unicodeBytesAsIntList, tempIPABytesInList))
                        {
                            currentMatch = match.unicodeBytesAsIntList;
                            break;
                        }
                    }
                    else if (match.unicodeBytesAsIntList.Count == 2)
                    {
                        if (isMatch = ParallelByteCheck(2, match.unicodeBytesAsIntList, tempIPABytesInList))
                        {
                            currentMatch = match.unicodeBytesAsIntList;
                            break;
                        }
                    }
                }

                if (isMatch)
                {
                    finishedBytesInList.Add(GetByteArrayFromIntList(currentMatch));
                    tempIPABytesInList.RemoveRange(0, currentMatch.Count);
                }
                else if (!isMatch)
                {
                    MessageBox.Show("Error: No Byte Match Found!");
                }

            }
            return finishedBytesInList;
        }

        public static byte[] GetByteArrayFromIntList(List<int> intList)
        {
            byte[] newByte = intList.Select(i => (byte) i).ToArray();

            return newByte;
        }

        public static List<string> GetStringListFromString(string word)
        {
            return GetStringListFromByteList(GetByteListFromIPAString(word));
        }

        public static string GetIPAStringFromDictionaryIPAList(List<DictionaryIPA> list)
        {
            string ipaString = "";

            foreach (var word in list)
            {
                ipaString = $"{ipaString}{String.Concat(IPAStringHelper.GetStringListFromString(word.ipa1))}";
            }

            return ipaString;
        }

        public static byte[] GetByteArrayFromString(string charString)
        {
            int byteCount = utf16.GetByteCount(charString);

            Byte[] wordBytes = new Byte[byteCount];

            wordBytes = utf16.GetBytes(charString);

            return wordBytes;
        }

        public static string ConvertPhraseToIPAChars(string phrase)
        {
            List<string> wordList = IPAStringHelper.SplitWordsIntoList(phrase);
            List<DictionaryIPA> PhraseAsListOfDictionaryIPA = new List<DictionaryIPA>();
            DataRepo _dr = new DataRepo();

            for (int i = 0; i < wordList.Count; i++)
            {
                PhraseAsListOfDictionaryIPA.Add(_dr.GetSingleEntry(wordList[i]));
            }

            return GetIPAStringFromDictionaryIPAList(PhraseAsListOfDictionaryIPA);
        }

    }
}
