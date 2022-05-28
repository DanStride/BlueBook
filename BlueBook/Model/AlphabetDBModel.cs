using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BlueBook.Model
{
    [Table("IPAlphabet")]
    public class AlphabetDBModel
    {
        [PrimaryKey]
        [Column("ID")]
        public int id { get; set; }

        [Column("Character")]
        public string character { get; set; }

        [Column("CharacterType")]
        public string charType { get; set; }

        [Column("VowelType")]
        public string vowelType { get; set; }

        [Column("VowelHeight")]
        public string vowelHeight { get; set; }

        [Column("VowelBackness")]
        public string vowelBackness { get; set; }

        [Column("VowelRoundedness")]
        public string vowelRoundedness { get; set; }

        [Column("ConsonantVoicing")]
        public string consonantVoicing { get; set; }

        [Column("ConsonantPlaceOfArticulation")]
        public string consonantPlaceOfArticulation { get; set; }

        [Column("ConsonantMannerOfArticulation")]
        public string consonantMannerOfArticualation { get; set; }
    }
}
