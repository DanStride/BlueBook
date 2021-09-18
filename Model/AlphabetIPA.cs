using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class AlphabetIPA
    {
        public List<CharacterIPA> ipaChars = new List<CharacterIPA> {
            new CharacterIPA
            {
                character = "iː",
                //unicodeBytes = 
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
                // this char no longer exists in db
                character = "ɑ̃",
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

        public AlphabetIPA()
        {
            Encoding utf16 = Encoding.Unicode;

            foreach (var item in ipaChars)
            {
                item.unicodeBytes = utf16.GetBytes(item.character);
            }

            for (int i = 0; i < ipaChars.Count; i++)
            {
                foreach (var b in ipaChars[i].unicodeBytes)
                {
                    ipaChars[i].unicodeBytesAsIntList.Add(b);
                }
            }
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "iː",
            //    charId = 1,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.high,
            //    vowelBackness = CharacterIPA.VowelBacknesses.front,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɑː",
            //    charId = 2,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "uː",
            //    charId = 3,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɔː",
            //    charId = 4,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.back,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɜː",
            //    charId = 5,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.slightlyround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɪ",
            //    charId = 6,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.high,
            //    vowelBackness = CharacterIPA.VowelBacknesses.front,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "æ",
            //    charId = 7,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ʊ",
            //    charId = 8,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɒ",
            //    charId = 9,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.slightlyround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ʌ",
            //    charId = 10,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɛ",
            //    charId = 11,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ə",
            //    charId = 12,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "b",
            //    charId = 13,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "d",
            //    charId = 14,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɡ",
            //    charId = 15,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "v",
            //    charId = 16,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.labiodental,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ð",
            //    charId = 17,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.interdental,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "z",
            //    charId = 18,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ʒ",
            //    charId = 19,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "d‍ʒ",
            //    charId = 20,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.affricate
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "l",
            //    charId = 21,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɹ",
            //    charId = 22,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "j",
            //    charId = 23,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.palatal,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "w",
            //    charId = 24,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "m",
            //    charId = 25,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "n",
            //    charId = 26,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ŋ",
            //    charId = 27,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.nasal
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "p",
            //    charId = 28,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.bilabial,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "t",
            //    charId = 29,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "k",
            //    charId = 30,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.stop
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "f",
            //    charId = 31,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.labiodental,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "θ",
            //    charId = 32,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.interdental,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "s",
            //    charId = 33,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.alveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ʃ",
            //    charId = 34,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "tʃ",
            //    charId = 35,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.postalveolar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.affricate
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "e‍ɪ",
            //    charId = 36,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "a‍ɪ",
            //    charId = 37,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɔ‍ɪ",
            //    charId = 38,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.front,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "a‍ʊ",
            //    charId = 39,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.back,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ə‍ʊ",
            //    charId = 40,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.back,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "i‍ə",
            //    charId = 41,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.high,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "e‍ə",
            //    charId = 42,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.diphthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.back,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "h",
            //    charId = 43,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.glottal,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɑ̃",
            //    charId = 44,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "i",
            //    charId = 45,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.high,
            //    vowelBackness = CharacterIPA.VowelBacknesses.front,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɐ",
            //    charId = 46,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.low,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.notround,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "ɔ",
            //    charId = 47,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.vowel,
            //    vowelType = CharacterIPA.VowelTypes.monophthong,
            //    vowelHeight = CharacterIPA.VowelHeights.mid,
            //    vowelBackness = CharacterIPA.VowelBacknesses.central,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.round,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.na,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.na,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.na
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "r",
            //    charId = 48,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiced,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.liquid
            //});
            //ipaChars.Add(new CharacterIPA
            //{
            //    character = "x",
            //    charId = 49,
            //    charLength = 2,
            //    characterType = CharacterIPA.CharacterTypes.consonant,
            //    vowelType = CharacterIPA.VowelTypes.na,
            //    vowelHeight = CharacterIPA.VowelHeights.na,
            //    vowelBackness = CharacterIPA.VowelBacknesses.na,
            //    vowelRoundedness = CharacterIPA.VowelRoundednesses.na,
            //    consonantVoicing = CharacterIPA.ConsonantVoicings.voiceless,
            //    consonantPlaceOfArticulation = CharacterIPA.ConsonantPlacesOfArticulation.velar,
            //    consonantMannerOfArticulation = CharacterIPA.ConsonantMannersOfArticulation.fricative
            
        }
    }
}
