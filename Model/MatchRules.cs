using BlueBook.Static_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueBook.Model
{
    public class MatchRules
    {
        Encoding utf16 = Encoding.Unicode;

        Dictionary<string, bool> selectionOptions;

        Dictionary<string, byte[]> allCharacterBytes = new Dictionary<string, byte[]>();


        // Consonants
        Dictionary<string, byte[]> ambiguousB_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousD_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousG_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousV_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousTHe_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousZ_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousSJ_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousDJ_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousL_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousR_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousJ_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousW_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousM_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousN_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousNG_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousP_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousT_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousK_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousF_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousTHink_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousS_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousSH_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousCH_Rules = new Dictionary<string, byte[]>();

        // Vowels
        Dictionary<string, byte[]> ambiguousEE_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousAR_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOO_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOR_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousIR_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousI_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousA_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOOt_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousO_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousU_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousE_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousAH_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousAY_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousEYE_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOY_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOU_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousOWE_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousEAR_Rules = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ambiguousAIR_Rules = new Dictionary<string, byte[]>();




        List<byte[]> allVowel_Rules = new List<byte[]>();

        public MatchRules(Dictionary<string, bool> selection)
        {
            selectionOptions = selection;

            allCharacterBytes = GetAllCharacterBytes();

            // Consonants
            ambiguousT_Rules = GetAmbiguityRules(AmbiguityRules.T);
            ambiguousF_Rules = GetAmbiguityRules(AmbiguityRules.F);
            ambiguousB_Rules = GetAmbiguityRules(AmbiguityRules.B);
            ambiguousD_Rules = GetAmbiguityRules(AmbiguityRules.D);
            ambiguousG_Rules = GetAmbiguityRules(AmbiguityRules.G);
            ambiguousV_Rules = GetAmbiguityRules(AmbiguityRules.V);
            ambiguousTHe_Rules = GetAmbiguityRules(AmbiguityRules.THe);
            ambiguousZ_Rules = GetAmbiguityRules(AmbiguityRules.Z);
            ambiguousSJ_Rules = GetAmbiguityRules(AmbiguityRules.SJ);
            ambiguousDJ_Rules = GetAmbiguityRules(AmbiguityRules.DJ);
            ambiguousL_Rules = GetAmbiguityRules(AmbiguityRules.L);
            ambiguousR_Rules = GetAmbiguityRules(AmbiguityRules.R);
            ambiguousJ_Rules = GetAmbiguityRules(AmbiguityRules.J);
            ambiguousW_Rules = GetAmbiguityRules(AmbiguityRules.W);
            ambiguousM_Rules = GetAmbiguityRules(AmbiguityRules.M);
            ambiguousN_Rules = GetAmbiguityRules(AmbiguityRules.N);
            ambiguousNG_Rules = GetAmbiguityRules(AmbiguityRules.NG);
            ambiguousP_Rules = GetAmbiguityRules(AmbiguityRules.P);
            ambiguousK_Rules = GetAmbiguityRules(AmbiguityRules.K);
            ambiguousTHink_Rules = GetAmbiguityRules(AmbiguityRules.THink);
            ambiguousS_Rules = GetAmbiguityRules(AmbiguityRules.S);
            ambiguousSH_Rules = GetAmbiguityRules(AmbiguityRules.SH);
            ambiguousCH_Rules = GetAmbiguityRules(AmbiguityRules.CH);

            //Vowels
            ambiguousEE_Rules = GetAmbiguityRules(AmbiguityRules.EE);
            ambiguousAR_Rules = GetAmbiguityRules(AmbiguityRules.AR);
            ambiguousOO_Rules = GetAmbiguityRules(AmbiguityRules.OO);
            ambiguousOR_Rules = GetAmbiguityRules(AmbiguityRules.OR);
            ambiguousIR_Rules = GetAmbiguityRules(AmbiguityRules.IR);
            ambiguousI_Rules = GetAmbiguityRules(AmbiguityRules.I);
            ambiguousA_Rules = GetAmbiguityRules(AmbiguityRules.A);
            ambiguousOOt_Rules = GetAmbiguityRules(AmbiguityRules.OOt);
            ambiguousO_Rules = GetAmbiguityRules(AmbiguityRules.O);
            ambiguousU_Rules = GetAmbiguityRules(AmbiguityRules.U);
            ambiguousE_Rules = GetAmbiguityRules(AmbiguityRules.E);
            ambiguousAH_Rules = GetAmbiguityRules(AmbiguityRules.AH);
            ambiguousAY_Rules = GetAmbiguityRules(AmbiguityRules.AY);
            ambiguousEYE_Rules = GetAmbiguityRules(AmbiguityRules.EYE);
            ambiguousOY_Rules = GetAmbiguityRules(AmbiguityRules.OY);
            ambiguousOU_Rules = GetAmbiguityRules(AmbiguityRules.OU);
            ambiguousOWE_Rules = GetAmbiguityRules(AmbiguityRules.OWE);
            ambiguousEAR_Rules = GetAmbiguityRules(AmbiguityRules.EAR);
            ambiguousAIR_Rules = GetAmbiguityRules(AmbiguityRules.AIR);

            allVowel_Rules = GetAllVowel_Rules();


        }


        private Dictionary<string, byte[]> GetAllCharacterBytes()
        {
            Dictionary<string, byte[]> allChars = new Dictionary<string, byte[]>();

            foreach (var character in IPAlphabet.ipaChars)
            {
                int byteCount = utf16.GetByteCount(character.character);

                Byte[] wordBytes = new Byte[byteCount];

                wordBytes = utf16.GetBytes(character.character);

                allChars.Add(character.character, wordBytes);
            }

            return allChars;
        }

        public byte[] GetSingleByteArray(string character)
        {
            return allCharacterBytes[character];
        }

        private Dictionary<string, byte[]> GetAmbiguityRules(string[] ruleset)
        {
            Dictionary<string, byte[]> byteList = new Dictionary<string, byte[]>();

            List<CharacterIPA> listCharIPA = new List<CharacterIPA>();

            foreach (var character in ruleset)
            {
                for (int i = 0; i < IPAlphabet.ipaChars.Count; i++)
                {
                    if (character == IPAlphabet.ipaChars[i].character) listCharIPA.Add(IPAlphabet.ipaChars[i]);
                }
            }

            foreach (var charIPA in listCharIPA)
            {
                int byteCount = utf16.GetByteCount(charIPA.character);

                Byte[] wordBytes = new Byte[byteCount];

                wordBytes = utf16.GetBytes(charIPA.character);

                byteList.Add(charIPA.character, wordBytes);
            }

            return byteList;
        }


        private List<byte[]> GetAllVowel_Rules()
        {
            // all vowels will match

            List<byte[]> byteList = new List<byte[]>();

            List<CharacterIPA> listCharIPA = new List<CharacterIPA>();

            foreach (var charIPA in IPAlphabet.ipaChars)
            {
                if (charIPA.characterType == CharacterIPA.CharacterTypes.vowel) listCharIPA.Add(charIPA);
            }

            foreach (var charIPA in listCharIPA)
            {
                int byteCount = utf16.GetByteCount(charIPA.character);

                Byte[] wordBytes = new Byte[byteCount];

                wordBytes = utf16.GetBytes(charIPA.character);

                byteList.Add(wordBytes);
            }

            return byteList;
        }

        public bool IsAmbiguousVowelMatch(string phrase, byte[] bytes)
        {
            bool isMatch = false;

            switch (phrase)
            {
                case "iː":
                    isMatch = DictionaryHasMatch(ambiguousEE_Rules, bytes);
                    break;

                case "ɑː":
                    isMatch = DictionaryHasMatch(ambiguousAR_Rules, bytes);
                    break;

                case "uː":
                    isMatch = DictionaryHasMatch(ambiguousOO_Rules, bytes);
                    break;

                case "ɔː":
                    isMatch = DictionaryHasMatch(ambiguousOR_Rules, bytes);
                    break;

                case "ɜː":
                    isMatch = DictionaryHasMatch(ambiguousIR_Rules, bytes);
                    break;

                case "ɪ":
                    isMatch = DictionaryHasMatch(ambiguousI_Rules, bytes);
                    break;

                case "æ":
                    isMatch = DictionaryHasMatch(ambiguousA_Rules, bytes);
                    break;

                case "ʊ":
                    isMatch = DictionaryHasMatch(ambiguousOOt_Rules, bytes);
                    break;

                case "ɒ":
                    isMatch = DictionaryHasMatch(ambiguousO_Rules, bytes);
                    break;

                case "ʌ":
                    isMatch = DictionaryHasMatch(ambiguousU_Rules, bytes);
                    break;

                case "ɛ":
                    isMatch = DictionaryHasMatch(ambiguousE_Rules, bytes);
                    break;

                case "ə":
                    isMatch = DictionaryHasMatch(ambiguousAH_Rules, bytes);
                    break;

                case "e‍ɪ":
                    isMatch = DictionaryHasMatch(ambiguousAY_Rules, bytes);
                    break;

                case "a‍ɪ":
                    isMatch = DictionaryHasMatch(ambiguousEYE_Rules, bytes);
                    break;

                case "ɔ‍ɪ":
                    isMatch = DictionaryHasMatch(ambiguousOY_Rules, bytes);
                    break;

                case "a‍ʊ":
                    isMatch = DictionaryHasMatch(ambiguousOU_Rules, bytes);
                    break;

                case "ə‍ʊ":
                    isMatch = DictionaryHasMatch(ambiguousOWE_Rules, bytes);
                    break;

                case "i‍ə":
                    isMatch = DictionaryHasMatch(ambiguousEAR_Rules, bytes);
                    break;

                case "e‍ə":
                    isMatch = DictionaryHasMatch(ambiguousAIR_Rules, bytes);
                    break;

                default:

                    break;
            }

            return isMatch;
        }

        public bool IsAmbiguousConsonantMatch(string phrase, byte[] bytes)
        {
            bool isMatch = false;

            switch (phrase)
            {
                case "t":
                    isMatch = DictionaryHasMatch(ambiguousT_Rules, bytes);
                    break;

                case "f":
                    isMatch = DictionaryHasMatch(ambiguousF_Rules, bytes);
                    break;

                case "b":
                    isMatch = DictionaryHasMatch(ambiguousB_Rules, bytes);
                    break;

                case "d":
                    isMatch = DictionaryHasMatch(ambiguousD_Rules, bytes);
                    break;

                case "ɡ":
                    isMatch = DictionaryHasMatch(ambiguousG_Rules, bytes);
                    break;

                case "v":
                    isMatch = DictionaryHasMatch(ambiguousV_Rules, bytes);
                    break;

                case "ð":
                    isMatch = DictionaryHasMatch(ambiguousTHe_Rules, bytes);
                    break;

                case "z":
                    isMatch = DictionaryHasMatch(ambiguousZ_Rules, bytes);
                    break;

                case "ʒ":
                    isMatch = DictionaryHasMatch(ambiguousSJ_Rules, bytes);
                    break;

                case "d‍ʒ":
                    isMatch = DictionaryHasMatch(ambiguousDJ_Rules, bytes);
                    break;

                case "l":
                    isMatch = DictionaryHasMatch(ambiguousL_Rules, bytes);
                    break;

                case "ɹ":
                    isMatch = DictionaryHasMatch(ambiguousR_Rules, bytes);
                    break;

                case "j":
                    isMatch = DictionaryHasMatch(ambiguousJ_Rules, bytes);
                    break;

                case "w":
                    isMatch = DictionaryHasMatch(ambiguousW_Rules, bytes);
                    break;

                case "m":
                    isMatch = DictionaryHasMatch(ambiguousM_Rules, bytes);
                    break;

                case "n":
                    isMatch = DictionaryHasMatch(ambiguousN_Rules, bytes);
                    break;

                case "ŋ":
                    isMatch = DictionaryHasMatch(ambiguousNG_Rules, bytes);
                    break;

                case "p":
                    isMatch = DictionaryHasMatch(ambiguousP_Rules, bytes);
                    break;

                case "k":
                    isMatch = DictionaryHasMatch(ambiguousK_Rules, bytes);
                    break;

                case "θ":
                    isMatch = DictionaryHasMatch(ambiguousTHink_Rules, bytes);
                    break;

                case "s":
                    isMatch = DictionaryHasMatch(ambiguousS_Rules, bytes);
                    break;

                case "ʃ":
                    isMatch = DictionaryHasMatch(ambiguousSH_Rules, bytes);
                    break;

                case "tʃ":
                    isMatch = DictionaryHasMatch(ambiguousCH_Rules, bytes);
                    break;

                default:

                    break;
            }

            return isMatch;
        }


        private bool DictionaryHasMatch(Dictionary<string, byte[]> dict, byte[] character)
        {
            bool hasMatch = false;

            foreach (var ipc in dict)
            {
                if (ipc.Value.SequenceEqual(character))
                {
                    hasMatch = true;
                    break;
                }
            }

            return hasMatch;
        }

    }
}
