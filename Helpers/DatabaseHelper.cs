using BlueBook.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BlueBook.Helpers
{
    public class DatabaseHelper
    {
        //ISSUE: This CurrentDirectoryString is different for testing
        //private string dbPath = ($"{Directory.GetCurrentDirectory()}\\DictionaryIPA.db");
        private string dbPath = "H:\\2021 PROGRAMMING\\Blue Book\\source\\repos\\BlueBook\\bin\\Debug\\netcoreapp3.1\\DictionaryIPA.db";

        private SQLiteConnection _db;

        private DictionaryIPA _data;

        public DatabaseHelper()
        {
            _db = new SQLiteConnection(dbPath);
            _data = new DictionaryIPA();
            _db.CreateTable<DictionaryIPA>();
            _db.CreateTable<DictionaryRelations>();
        }

        public DictionaryIPA ReturnSingleDBQuery(string query)
        {
            _data = _db.Query<DictionaryIPA>(query).FirstOrDefault();

            return _data;
        }

        public List<DictionaryIPA> GetEntireDBList()
        {
            return _db.Query<DictionaryIPA>("SELECT * FROM DictionaryIPA");
        }

        public void UpdateDBEntry(DictionaryIPA ipa)
        {
            _db.Update(ipa);
        }

        public List<DictionaryRelations> ReturnDictionaryRelationsList(string query)
        {
            List<DictionaryRelations> drelList = new List<DictionaryRelations>();

            drelList = _db.Query<DictionaryRelations>(query);

            return drelList;
        }

        public void InsertIntoDB(object DBEntry)
        {
            _db.Insert(DBEntry);
        }

        public int GetDataBaseCount()
        {
            return _db.Query<DictionaryIPA>("SELECT * FROM DictionaryIPA").LastOrDefault().id;
        }

        public List<DictionaryIPA> GetListOfDictionaryIPA(string query)
        {
            List<DictionaryIPA> listIPA = new List<DictionaryIPA>();

            listIPA = _db.Query<DictionaryIPA>(query);

            return listIPA;
        }

    }
}
