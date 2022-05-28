using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class CharacterIPA
    {
        public enum CharacterTypes
        {
            vowel,
            consonant
        };

        public enum VowelTypes
        {
            monophthong,
            diphthong,
            na
        };

        public enum VowelHeights
        {
            high,
            mid,
            low,
            na
        };

        public enum VowelBacknesses
        {
            front,
            central,
            back,
            na
        };

        public enum VowelRoundednesses
        {
            round,
            slightlyround,
            notround,
            na
        };

        public enum ConsonantVoicings
        {
            voiced,
            voiceless,
            na
        };

        public enum ConsonantPlacesOfArticulation
        {
            bilabial,
            labiodental,
            interdental,
            alveolar,
            postalveolar,
            palatal,
            velar,
            glottal,
            na
        };

        public enum ConsonantMannersOfArticulation
        {
            stop,
            fricative,
            affricate,
            nasal,
            liquid,
            glide,
            tap,
            na
        };

        public string character { get; set; }
        public byte[] unicodeBytes { get; set; }

        public List<int> unicodeBytesAsIntList { get; set; }

        public int charId { get; set; }
        public int charLength { get; set; }
        public CharacterTypes characterType { get; set; }
        public VowelTypes vowelType { get; set; }
        public VowelHeights vowelHeight { get; set; }
        public VowelBacknesses vowelBackness { get; set; }
        public VowelRoundednesses vowelRoundedness { get; set; }
        public ConsonantVoicings consonantVoicing { get; set; }
        public ConsonantPlacesOfArticulation consonantPlaceOfArticulation { get; set; }
        public ConsonantMannersOfArticulation consonantMannerOfArticulation { get; set; }

        public CharacterIPA()
        {
            unicodeBytesAsIntList = new List<int>();
        }
    }
}
