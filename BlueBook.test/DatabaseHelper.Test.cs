using BlueBook.Helpers;
using BlueBook.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.test
{
    [TestClass]
    public class DatabaseHelperTest
    {
        DatabaseHelper dh = new DatabaseHelper();

        [TestMethod]
        public void ReturnSingleDBQuery_ReturnsCorrectQuery()
        {
            DictionaryIPA dictionaryIPA = new DictionaryIPA();

            dictionaryIPA.english = "compartment";
            dictionaryIPA.ipa1 = "kəmpɑːtmənt";

            string searchQuery = "compartment";

            DictionaryIPA actualIPA = dh.ReturnSingleDBQuery(searchQuery);

            Assert.AreEqual(dictionaryIPA.english, actualIPA.english);
            Assert.AreEqual(dictionaryIPA.ipa1, actualIPA.ipa1);
        }

        [TestMethod]
        public void GetEntireDBList_ReturnsEntireDBList()
        {
            List<DictionaryIPA> entireList = dh.GetEntireDBList();

            Assert.IsTrue(entireList.Count > 65000);
        }

        [TestMethod]
        public void GetDataBaseCount_ReturnsCount()
        {
            int count = dh.GetDataBaseCount();

            Assert.IsTrue(count > 65000);
        }

        [TestMethod]
        // This test depends on GetDataBaseCount() and GetEntryByID()
        public void InsertIntoDB_CheckEntryWasInserted_CheckEntryWasDeleted()
        {
            // INSERT
            DictionaryIPA newEntry = new DictionaryIPA();
            newEntry.english = "TESTINSERT";
            newEntry.ipa1 = "ipachars";

            dh.InsertIntoDB(newEntry);

            DictionaryIPA checkEntry = dh.ReturnSingleDBQuery("TESTINSERT");

            Assert.AreEqual(newEntry.english, checkEntry.english);
            Assert.AreEqual(newEntry.ipa1, checkEntry.ipa1);

            // REMOVE

            dh.RemoveDatabaseEntryByWord("TESTINSERT");

            DictionaryIPA nullEntry = dh.ReturnSingleDBQuery("TESTINSERT");

            Assert.IsTrue(nullEntry == null);

        }

        [TestMethod]
        public void GetListOfDictionaryIPA_ReturnsDataInAllColumns()
        {
            List<DictionaryIPA> completeList = dh.GetListOfDictionaryIPA();

            for (int i = 0; i < completeList.Count; i++)
            {
                Assert.IsNotNull(completeList[i].english);
                Assert.IsNotNull(completeList[i].ipa1);
            }
        }

        [TestMethod]
        public void GetEntryByID_ResultsNotNullOrEmpty()
        {
            DictionaryIPA entry = dh.GetEntryByID(666);

            Assert.IsNotNull(entry.english);
            Assert.IsNotNull(entry.ipa1);
        }
    }
}
