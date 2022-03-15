using BlueBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueBook.Static_Classes
{
    public static class IPAlphabet
    {
        public static readonly List<CharacterIPA> ipaChars = new List<CharacterIPA> {
            new CharacterIPA
            {
                character = "iː",
                unicodeBytesAsIntList = { 105, 0, 208, 2 },
                charId = 1,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.high,
                vowelBackness = CharacterIPA.VowelBacknesses.front,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɑː",
                unicodeBytesAsIntList =  {81, 2, 208, 2 },
                charId = 2,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "uː",
                unicodeBytesAsIntList = { 117, 0, 208, 2 },
                charId = 3,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɔː",
                unicodeBytesAsIntList = { 84, 2, 208, 2 },
                charId = 4,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.back,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɜː",
                unicodeBytesAsIntList = { 92, 2, 208, 2 },
                charId = 5,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.slightlyround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɪ",
                unicodeBytesAsIntList = { 106, 2 },
                charId = 6,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.high,
                vowelBackness = CharacterIPA.VowelBacknesses.front,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "æ",
                unicodeBytesAsIntList = { 230, 0 },
                charId = 7,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ʊ",
                unicodeBytesAsIntList = { 138, 2 },
                charId = 8,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɒ",
                unicodeBytesAsIntList = { 82, 2 },
                charId = 9,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.slightlyround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ʌ",
                unicodeBytesAsIntList = { 140, 2 },
                charId = 10,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɛ",
                unicodeBytesAsIntList = { 91, 2 },
                charId = 11,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ə",
                unicodeBytesAsIntList = { 89, 2 },
                charId = 12,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "b",
                unicodeBytesAsIntList = { 98, 0 },
                charId = 13,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "d",
                unicodeBytesAsIntList = { 100, 0 },
                charId = 14,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "ɡ",
                unicodeBytesAsIntList = { 97, 2 },
                charId = 15,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "v",
                unicodeBytesAsIntList = { 118, 0 },
                charId = 16,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.labiodental,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "ð",
                unicodeBytesAsIntList = { 240, 0 },
                charId = 17,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.interdental,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "z",
                unicodeBytesAsIntList = { 122, 0 },
                charId = 18,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "ʒ",
                unicodeBytesAsIntList = { 146, 2 },
                charId = 19,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "d‍ʒ",
                unicodeBytesAsIntList = { 100, 0, 13, 32, 146, 2 },
                charId = 20,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.affricate
            },
            new CharacterIPA
            {
                character = "l",
                unicodeBytesAsIntList = { 108, 0 },
                charId = 21,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            },
            new CharacterIPA
            {
                character = "ɹ",
                unicodeBytesAsIntList = { 121, 2 },
                charId = 22,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            },
            new CharacterIPA
            {
                character = "j",
                unicodeBytesAsIntList = { 106, 0 },
                charId = 23,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.palatal,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            },
            new CharacterIPA
            {
                character = "w",
                unicodeBytesAsIntList = { 119, 0 },
                charId = 24,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            },
            new CharacterIPA
            {
                character = "m",
                unicodeBytesAsIntList = { 109, 0 },
                charId = 25,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            },
            new CharacterIPA
            {
                character = "n",
                unicodeBytesAsIntList = { 110, 0 },
                charId = 26,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            },
            new CharacterIPA
            {
                character = "ŋ",
                unicodeBytesAsIntList = { 75, 1 },
                charId = 27,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            },
            new CharacterIPA
            {
                character = "p",
                unicodeBytesAsIntList = { 112, 0 },
                charId = 28,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "t",
                unicodeBytesAsIntList = { 116, 0 },
                charId = 29,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "k",
                unicodeBytesAsIntList = { 107, 0 },
                charId = 30,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            },
            new CharacterIPA
            {
                character = "f",
                unicodeBytesAsIntList = { 102, 0 },
                charId = 31,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.labiodental,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "θ",
                unicodeBytesAsIntList = { 184, 3 },
                charId = 32,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.interdental,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "s",
                unicodeBytesAsIntList = { 115, 0 },
                charId = 33,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "ʃ",
                unicodeBytesAsIntList = { 131, 2 },
                charId = 34,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                character = "tʃ",
                unicodeBytesAsIntList = { 116, 0, 131, 2 },
                charId = 35,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.affricate
            },
            new CharacterIPA
            {
                character = "e‍ɪ",
                unicodeBytesAsIntList = { 101, 0, 13, 32, 106, 2 },
                charId = 36,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "a‍ɪ",
                unicodeBytesAsIntList = { 97, 0, 13, 32, 106, 2 },
                charId = 37,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɔ‍ɪ",
                unicodeBytesAsIntList = { 84, 2, 13, 32, 106, 2 },
                charId = 38,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.front,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "a‍ʊ",
                unicodeBytesAsIntList = { 97, 0, 13, 32, 138, 2 },
                charId = 39,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.back,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ə‍ʊ",
                unicodeBytesAsIntList = { 89, 2, 13, 32, 138, 2 },
                charId = 40,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.back,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "i‍ə",
                unicodeBytesAsIntList = { 105, 0, 13, 32, 89, 2 },
                charId = 41,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.high,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "e‍ə",
                unicodeBytesAsIntList = { 101, 0, 13, 32, 89, 2 },
                charId = 42,
                charLength = 3,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.diphthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.back,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "h",
                unicodeBytesAsIntList = { 104, 0 },
                charId = 43,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.glottal,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            },
            new CharacterIPA
            {
                // kwɑːsɑ and kwɑːsɑs were replaced
                // this char is no longer used in db
                character = "ɑ̃",
                unicodeBytesAsIntList = { 81, 2, 3, 3 },
                charId = 44,
                charLength = 2,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "i",
                unicodeBytesAsIntList = { 105, 0 },
                charId = 45,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.high,
                vowelBackness = CharacterIPA.VowelBacknesses.front,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɐ",
                unicodeBytesAsIntList = { 80, 2 },
                charId = 46,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.low,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "ɔ",
                unicodeBytesAsIntList = { 84, 2 },
                charId = 47,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.vowel,
                vowelType = CharacterIPA.VowelTypes.monophthong,
                vowelHeight = CharacterIPA.VowelHeights.mid,
                vowelBackness = CharacterIPA.VowelBacknesses.central,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
                consonantVoicing = CharacterIPA.ConsonantVoicings.na,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            },
            new CharacterIPA
            {
                character = "r",
                unicodeBytesAsIntList = { 114, 0 },
                charId = 48,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            },
            new CharacterIPA
            {
                character = "x",
                unicodeBytesAsIntList = { 120, 0 },
                charId = 49,
                charLength = 1,
                characterType = CharacterIPA.CharacterTypes.consonant,
                vowelType = CharacterIPA.VowelTypes.na,
                vowelHeight = CharacterIPA.VowelHeights.na,
                vowelBackness = CharacterIPA.VowelBacknesses.na,
                vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
                consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
                consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
                consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative

            }
        };

        public static CharacterIPA ReturnCharacterIPAByCharacterString(string characterString)
        {
            var query = from c in ipaChars
                        where c.character == characterString
                        select c;

            return query.FirstOrDefault();
        }
    }
}
