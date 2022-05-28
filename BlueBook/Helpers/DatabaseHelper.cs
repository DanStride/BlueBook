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
        private string dbPath = "";

        private SQLiteConnection _db;

        private DictionaryIPA _data;

        public DatabaseHelper()
        {
            dbPath = GetDatabaseString();
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

        private string GetDatabaseString()
        {
            string path = Directory.GetCurrentDirectory();

            for (int i = 0; i < 3; i++)
            {
                path = Directory.GetParent(path).FullName;
            }

            path = $"{path}\\_Database\\DictionaryIPA.db";

            return path;
        }

        public void RemoveDatabaseEntryByWord(string word)
        {
            _db.Query<DictionaryIPA>($"DELETE FROM DictionaryIPA WHERE ENGLISH = '{word}'").FirstOrDefault();
        }

    }
}
