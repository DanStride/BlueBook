using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BlueBook.Model
{
    [Table("DictionaryRelations")]
    public class DictionaryRelations
    {
        [PrimaryKey, AutoIncrement]
        [Column("LinkID")]
        public int id { get; set; }

        [Column("PrimaryWordID")]
        public int primaryWordId { get; set; }

        [Column("SecondaryWordID")]
        public int secondaryWordId { get; set; }

        [Column("PrimaryWordStartIndex")]
        public int primaryWordStartIndex { get; set; }

        [Column("PrimaryWordEndIndex")]
        public int primaryWordEndIndex { get; set; }

        [Column("SecondaryWordStartIndex")]
        public int secondaryWordStartIndex { get; set; }

        [Column("SecondaryWordEndIndex")]
        public int secondaryWordEndIndex { get; set; }


    }
}
