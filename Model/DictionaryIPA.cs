using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BlueBook.Model
{
    [Table("DictionaryIPA")]
    public class DictionaryIPA
    {
        [PrimaryKey, AutoIncrement]
        [Column("ID")]
        public int  id { get; set; }

        [Column("English")]
        public string english { get; set; }

        [Column("IPA1")]
        public string ipa1 { get; set; }

        [Column("IPA2")]
        public string ipa2 { get; set; }

        [Column("IPA3")]
        public string ipa3 { get; set; }
    }
}
