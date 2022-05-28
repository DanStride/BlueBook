using BlueBook.Logic;
using BlueBook.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.test
{
    [TestClass]
    public class AmbiguitySearcherTest
    {
        [TestMethod]
        public void ProcessAndReturnResults_ReturnsAResult()
        {
            AmbiguitySearcher searcher = new AmbiguitySearcher("cat", SetSelectionsFalse());

            ResultData resultData = searcher.ProcessAndReturnResults();

            Assert.IsNotNull(resultData);
            Assert.IsTrue(resultData.Results.Count > 0);
        }

        [TestMethod]
        public void ConvertPhraseIntoListOfDictionaryIPA_ReturnsCorrectResult()
        {
            AmbiguitySearcher searcher = new AmbiguitySearcher("cat fish bird", SetSelectionsFalse());
            List<string> expectedIPA = new List<string> { "kæt", "fɪʃ", "bɜːd" };

            List<DictionaryIPA> actualIPA = searcher.ConvertPhraseIntoListOfDictionaryIPA();

            Assert.IsNotNull(actualIPA);

            for (int i = 0; i < expectedIPA.Count; i++)
            {
                Assert.AreEqual(expectedIPA[i], actualIPA[i].ipa1);
            }
        }

        private Dictionary<string, bool> SetSelectionsFalse()
        {
            Dictionary<string, bool> selection = new Dictionary<string, bool>();
            selection.Add("AmbiguousConsonants", false);
            selection.Add("AmbiguousVowels", false);
            return selection;
        }
    }
}
