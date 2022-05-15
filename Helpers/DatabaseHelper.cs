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
        //private string dbPath = ($"{Directory.GetCurrentDirectory()}\\DictionaryIPA.db");

        // Use this string for testing
        private string dbPath = "C:\\MyRepos\\BlueBook\\_Database\\DictionaryIPA.db";

        private SQLiteConnection _db;

        private DictionaryIPA _data;

        public DatabaseHelper()
        {
            _db = new SQLiteConnection(dbPath);
            _data = new DictionaryIPA();
            _db.CreateTable<DictionaryIPA>();
        }

        public DictionaryIPA ReturnSingleDBQuery(string query)
        {
            return _db.Query<DictionaryIPA>($"SELECT * FROM DictionaryIPA WHERE English = '{query}'").FirstOrDefault();
        }

        public List<DictionaryIPA> GetEntireDBList()
        {
            return _db.Query<DictionaryIPA>("SELECT * FROM DictionaryIPA");
        }

        public void InsertIntoDB(object DBEntry)
        {
            _db.Insert(DBEntry);
        }

        public int GetDataBaseCount()
        {
            return _db.Query<DictionaryIPA>("SELECT * FROM DictionaryIPA").LastOrDefault().id;
        }

        public List<DictionaryIPA> GetListOfDictionaryIPA()
        {
            return _db.Query<DictionaryIPA>("SELECT * FROM DictionaryIPA");
        }

        public DictionaryIPA GetEntryByID(int id)
        {
            return _db.Query<DictionaryIPA>($"SELECT * FROM DictionaryIPA WHERE ID = '{id}'").FirstOrDefault();
        }

    }
}
