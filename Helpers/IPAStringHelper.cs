using BlueBook.Model;
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
            Encoding utf16 = Encoding.Unicode;

            List<string> stringList = new List<string>();

            foreach (var byteset in bytes)
            {
                stringList.Add(utf16.GetString(byteset));
            }
            


            return stringList;
        }

        public static List<byte[]> GetByteListFromString(string word)
        {

            Encoding utf16 = Encoding.Unicode;
            AlphabetIPA aipa = new AlphabetIPA();

            List<int> tempWordBytesInList = new List<int>();
            List<byte[]> finishedBytesInList = new List<byte[]>();

            // Get necessary length for byte array
            int byteCount = utf16.GetByteCount(word);

            // Instantiate new byte array
            Byte[] wordBytes = new Byte[byteCount];

            // Populate byte array 
            wordBytes = utf16.GetBytes(word);

            // Populate Byte List
            foreach (var b in wordBytes)
            {
                tempWordBytesInList.Add(b);
            }

            // WTF IS THIS?
            byte[] testbytes = new byte[] { 108, 0 };
            string test = utf16.GetString(testbytes);

            // FIND LARGEST PIECES FIRST, 3 PASSES

            // iterate byte[] to get it into an array or list

            // find all instances of a match on the first byte
            // check byte size of letter for each match
            // check the rest of the matches for that size
            // if ok, add to list list int the bytes



            while (tempWordBytesInList.Count > 0)
            {
                bool isMatch = true;
                CharacterIPA currentMatch = new CharacterIPA();

                // Check for the mysterious 13, 32 empty char
                if ((tempWordBytesInList[0] == 13) && (tempWordBytesInList[1] == 32))
                {
                    tempWordBytesInList.RemoveRange(0, 2);
                }

                // Find all matches with same first byte
                var alphabetMatches = aipa.ipaChars.Where(a => a.unicodeBytesAsIntList.First().Equals(tempWordBytesInList[0]))
                                        .OrderByDescending(c => c.unicodeBytes.Length)
                                        .ToList();

                if (alphabetMatches.Count > 0)
                {
                    foreach (var match in alphabetMatches)
                    {
                        isMatch = true;
                        if (match.unicodeBytes.Length == 6 && tempWordBytesInList.Count >= 6)
                        {
                            // Check remainder of byte matches starting with the larger possibilities
                            for (int p = 0; p < 6; p++)
                            {
                                // Checking chars against the zeroeth index and up of the word
                                if (match.unicodeBytesAsIntList[p] != tempWordBytesInList[p])
                                {
                                    isMatch = false;
                                    break;
                                }
                            }
                        }
                        else if (match.unicodeBytes.Length == 4 && tempWordBytesInList.Count >= 4)
                        {

                            for (int p = 0; p < 4; p++)
                            {
                                // Checking chars against the zeroeth index and up of the word
                                if (match.unicodeBytesAsIntList[p] != tempWordBytesInList[p])
                                {
                                    isMatch = false;
                                    break;
                                }
                            }
                        }
                        else if (match.unicodeBytes.Length == 2)
                        {
                            for (int p = 0; p < 2; p++)
                            {
                                // Checking chars against the zeroeth index and up of the word
                                if (match.unicodeBytesAsIntList[p] != tempWordBytesInList[p])
                                {
                                    isMatch = false;
                                    break;
                                }
                            }
                        }
                        else if (match.unicodeBytes.Length > tempWordBytesInList.Count)
                        {
                            isMatch = false;
                        }

                        if (isMatch)
                        {
                            currentMatch = match;
                            break;
                        }

                    }

                    if (isMatch && currentMatch != null)
                    {
                        finishedBytesInList.Add(currentMatch.unicodeBytes);

                        tempWordBytesInList.RemoveRange(0, currentMatch.unicodeBytes.Length);
                    }

                    else
                    {
                        MessageBox.Show("there were no unicode byte matches. Something went wrong");
                    }
                }
                else
                {
                    MessageBox.Show("There was no byte match found for the next character, something went wrong.");
                }

            }

            return finishedBytesInList;
        }

        public static List<string> GetStringListFromString(string word)
        {
            return GetStringListFromByteList(GetByteListFromString(word));
        }

    }
}
