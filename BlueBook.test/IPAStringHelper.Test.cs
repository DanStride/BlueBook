using BlueBook.Helpers;
using BlueBook.Model;
using BlueBook.Static_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueBook.test
{
    [TestClass]
    public class IPAStringHelperTest
    {

        [TestMethod]
        public void CleanIPA_RemovesCorrectCharacters()
        {
            string testString = "fuˈlloˌfˈthingstoˈremˌoveˌˌ";
            string expectedString = "fullofthingstoremove";

            string actualString = IPAStringHelper.CleanIPA(testString);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void SplitWordsIntoList_ReturnsCorrectListOfWords()
        {
            string testString = "these words belong in a list";
            List<string> expectedList = new List<string> { "these", "words", "belong", "in", "a", "list" };

            List<string> actualList = IPAStringHelper.SplitWordsIntoList(testString);

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }
        }

        [TestMethod]
        public void GetStringListFromByteList_ReturnsCorrectStringList()
        {
            List<byte[]> byteList = new List<byte[]>();
            byteList.Add(new byte[2] { 97, 2 });
            byteList.Add(new byte[4] { 89, 2, 138, 2 });

            List<string> expectedStringList = new List<string> { "ɡ", "əʊ" };
            List<string> actualStringList = new List<string>();

            actualStringList = IPAStringHelper.GetStringListFromByteList(byteList);

            for (int i = 0; i < expectedStringList.Count; i++)
            {
                Assert.AreEqual(expectedStringList[i], actualStringList[i]);
            }
        }

        [TestMethod]
        public void GetStringFromByteArray_ReturnsCorrectString()
        {
            byte[] byteArray = new byte[4] { 89, 2, 138, 2 };

            string expectedString = "əʊ";

            string actualString = IPAStringHelper.GetStringFromByteArray(byteArray);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void GetIntListFromByteArray_ReturnsCorrectIntList()
        {
            List<int> expectedIntList = new List<int> { 89, 2, 138, 2 };
            byte[] byteArray = new byte[4] { 89, 2, 138, 2 };
            List<int> actualIntList = new List<int>();

            actualIntList = IPAStringHelper.GetIntListFromByteArray(byteArray);

            for (int i = 0; i < expectedIntList.Count; i++)
            {
                Assert.AreEqual(expectedIntList[i], actualIntList[i]);
            }
            
        }

        [TestMethod]
        public void RemoveThirteenThirtyTwoFromBeginningOfIntList_RemovesThirteenThirtyTwo()
        {
            List<int> expectedList = new List<int> { 89, 2, 138, 2 };
            List<int> listToFix = new List<int> { 13, 32, 89, 2, 138, 2 };
            List<int> actualList = new List<int>();

            actualList = IPAStringHelper.RemoveThirteenThirtyTwoFromBeginningOfIntList(listToFix);

            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }
        }

        [TestMethod]
        public void ParallelByteCheck_ReturnsTrueIfElementsMatch()
        {
            List<int> alphabetChar = new List<int> { 89, 2, 138, 2 };
            List<int> wordChar = new List<int> { 89, 2, 138, 2 };
            int counter = 4;

            Assert.IsTrue(IPAStringHelper.ParallelByteCheck(counter, alphabetChar, wordChar));
        }

        [TestMethod]
        public void ParallelByteCheck_ReturnsFalseIfElementsDoNotMatch()
        {
            List<int> alphabetChar = new List<int> { 89, 2, 138, 2 };
            List<int> wordChar = new List<int> { 89, 62, 138, 2 };
            int counter = 4;

            Assert.IsFalse(IPAStringHelper.ParallelByteCheck(counter, alphabetChar, wordChar));
        }

        [TestMethod]
        public void GetByteListFromIPAString_ReturnsCorrectByteArrayList()
        {
            string ipaString = "ɡəʊ";

            List<byte[]> expectedBytes = new List<byte[]>();
            expectedBytes.Add(new byte[2] { 97, 2 });
            expectedBytes.Add(new byte[2] { 89, 2 });
            expectedBytes.Add(new byte[2] { 138, 2 });

            List<byte[]> actualIntList = IPAStringHelper.GetByteListFromIPAString(ipaString);

            for (int i = 0; i < expectedBytes.Count; i++)
            {
                Assert.IsTrue(expectedBytes[i].SequenceEqual(actualIntList[i]));
            }
        }

        [TestMethod]
        public void GetByteArrayFromIntList_ReturnsCorrectIntList()
        {
            byte[] expectedByteArray = new byte[4] { 89, 2, 138, 2 };
            List<int> intList = new List<int> { 89, 2, 138, 2 };

            byte[] actualByteArray = IPAStringHelper.GetByteArrayFromIntList(intList);

            Assert.IsTrue(expectedByteArray.SequenceEqual(actualByteArray));
        }

        [TestMethod]
        public void GetStringListFromString_ReturnsCorrectStringList()
        {
            List<string> expectedStringList = new List<string> { "ɐ", "d", "ɒ", "p", "t" };
            string wordInIPA = "ɐdɒpt";

            List<string> actualStringList = IPAStringHelper.GetStringListFromString(wordInIPA);

            for (int i = 0; i < expectedStringList.Count; i++)
            {
                Assert.AreEqual(expectedStringList[i], actualStringList[i]);
            }
        }

        [TestMethod]
        public void GetIPAStringFromDictionaryIPAList_ReturnsCorrectIPAString()
        {
            string expectedString = "a‍ʊtklɑːswɜːkɐɐdɒpt";
            string actualString = "";

            DictionaryIPA ipaObject1 = new DictionaryIPA { english = "outclass", id = 39277, ipa1 = "a‍ʊtklɑːs" };
            DictionaryIPA ipaObject2 = new DictionaryIPA { english = "worker", id = 64536, ipa1 = "wɜːkɐ" };
            DictionaryIPA ipaObject3 = new DictionaryIPA { english = "adopt", id = 733, ipa1 = "ɐdɒpt" };

            List<DictionaryIPA> listIPA = new List<DictionaryIPA> { ipaObject1, ipaObject2, ipaObject3 };

            actualString = IPAStringHelper.GetIPAStringFromDictionaryIPAList(listIPA);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void GetByteArrayFromString_ReturnsCorrectByteArray()
        {
            byte[] expectedByteArray = new byte[4] { 89, 2, 138, 2 };
            string charString = "əʊ";

            byte[] actualByteArray = IPAStringHelper.GetByteArrayFromString(charString);

            Assert.IsTrue(expectedByteArray.SequenceEqual(actualByteArray));
        }

        [TestMethod]
        public void RemoveThirteenThirtyTwoFromByteList_RemovesCorrectBytes()
        {
            List<byte[]> byteListToClean = new List<byte[]>();
            byteListToClean.Add(new byte[] { 13, 32 });
            byteListToClean.Add(new byte[] { 36, 62 });
            byteListToClean.Add(new byte[] { 13, 63 });
            byteListToClean.Add(new byte[] { 03, 32 });
            byteListToClean.Add(new byte[] { 13, 32 });
            byteListToClean.Add(new byte[] { 34, 83 });

            List<byte[]> expectedByteList = new List<byte[]>();
            {
            byteListToClean.Add(new byte[] { 36, 62 });
            byteListToClean.Add(new byte[] { 13, 63 });
            byteListToClean.Add(new byte[] { 03, 32 });
            byteListToClean.Add(new byte[] { 34, 83 });
            }

            List<byte[]> actualByteList = IPAStringHelper.RemoveThirteenThirtyTwoFromByteList(byteListToClean);

            for (int i = 0; i < expectedByteList.Count; i++)
            {
                Assert.IsTrue(expectedByteList[i].SequenceEqual(actualByteList[i]));
            }
        }
    }
}
