using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlueBook.Model;
using System.Linq;
using BlueBook.Helpers;
using System.Collections.Generic;
using System;

namespace BlueBook.test
{
    [TestClass]
    public class DataRepoTest
    {
        DataRepo dataRepo = new DataRepo();

        [TestMethod]
        public void WordsNotFoundInDB_ReturnsListOfWordsNotInDB()
        {
            List<string> words = dataRepo.WordsNotFoundInDB("gewg asdg rth");

            Assert.AreEqual("gewg", words[0]);
            Assert.AreEqual("asdg", words[1]);
            Assert.AreEqual("rth", words[2]);
        }

        [TestMethod]
        public void VerifyExistenceOfWord_ReturnsTrueForRealWord()
        {
            bool wordIsInDB = dataRepo.VerifyExistenceOfWord("captain");

            Assert.IsTrue(wordIsInDB);
        }

        [TestMethod]
        public void VerifyExistenceOfWord_ReturnsFalseForFakeWord()
        {
            bool wordIsInDB = dataRepo.VerifyExistenceOfWord("shnaplebox");

            Assert.IsFalse(wordIsInDB);
        }

        [TestMethod]
        public void GetEntireDictionaryIPAList_ReturnsNonNullResults()
        {
            List<DictionaryIPA> list = dataRepo.GetEntireDictionaryIPAList();

            Assert.IsNotNull(list);

            for (int i = 0; i < list.Count; i++)
            {
                Assert.IsFalse(String.IsNullOrEmpty(list[i].english));
                Assert.IsFalse(String.IsNullOrEmpty(list[i].ipa1));
            }
        }

        [TestMethod] 
        public void GetSingleEntry_ReturnsCorrectDBEntry()
        {
            DictionaryIPA ipaExpected = dataRepo.GetSingleEntry("compartment");
            DictionaryIPA ipaActual = new DictionaryIPA();

            ipaActual.english = "compartment";
            ipaActual.ipa1 = "kəmpɑːtmənt";

            Assert.AreEqual(ipaExpected.english, ipaActual.english);
            Assert.AreEqual(ipaExpected.ipa1, ipaActual.ipa1);
        }
    }
}
