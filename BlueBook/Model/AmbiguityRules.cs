using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public class AmbiguityRules
    {
        // T - t, d, the, think
        public readonly string[] T = { "t", "d", "ð", "θ" };

        // F - f, v
        public readonly string[] F = { "f", "v" };

        // B - b, v, p
        public readonly string[] B = { "b", "v", "p" };

        // D - d, th, z, d3, 3, t, th, 
        public readonly string[] D = { "d", "ð", "z", "d‍ʒ", "ʒ", "t", "θ" };

        // G - g, k,
        public readonly string[] G = { "ɡ", "k" };

        // V - v, b, j, w, f
        public readonly string[] V = { "v", "b", "j", "w", "f" };

        // THe - th, d, z, d3, t, th
        public readonly string[] THe = { "ð", "d", "z", "d‍ʒ", "t", "θ" };



        // Z - z, 3, d3, s, sh, ch
        public readonly string[] Z = { "z", "ʒ", "d‍ʒ", "s", "ʃ", "tʃ" };

        // 3 - 3, d3, j, s, sh
        public readonly string[] SJ = { "ʒ", "d‍ʒ", "j", "s", "ʃ" };

        // d3 - d3, 3, d, ch
        public readonly string[] DJ = { "d‍ʒ", "ʒ", "d", "tʃ" };

        // L - l, r, w
        public readonly string[] L = { "l", "ɹ", "w" };

        // R - r, l, v, w
        public readonly string[] R = { "ɹ", "l", "v", "w" };

        // J - j, 3, d3, w
        public readonly string[] J = { "j", "ʒ", "d‍ʒ", "w" };

        // W - w, v, r
        public readonly string[] W = { "w", "v", "ɹ" };

        // M - m, b
        public readonly string[] M = { "m", "b" };

        // N - n, d, ng
        public readonly string[] N = { "n", "d", "ŋ" };

        // NG - ng, n
        public readonly string[] NG = { "ŋ", "n" };

        // P - p, b, v, m
        public readonly string[] P = { "p", "b", "v", "m" };




        // K - k, g
        public readonly string[] K = { "k", "ɡ" };



        // THink - think, d, the, t, f, ch
        public readonly string[] THink = { "θ", "d", "ð", "t", "f", "tʃ" };

        // S - s, z, 3, d3, sh, ch 
        public readonly string[] S = { "s", "z", "ʒ", "d‍ʒ", "ʃ", "tʃ" };

        // SH - sh, 3, d3, ch
        public readonly string[] SH = { "ʃ", "ʒ", "d‍ʒ", "tʃ" };

        // CH - ch, 3, d3, t, sh
        public readonly string[] CH = { "tʃ", "ʒ", "d‍ʒ", "t", "ʃ" };

        //All consonants
        public readonly string[] allConsonants = { "b", "d", "ɡ", "v", "ð", "z", "ʒ", "d‍ʒ", "l", "ɹ", "j", "w", "m", "n", "ŋ", "p", "t", "k", "f", "θ", "s", "ʃ", "tʃ" };









        // All vowels
        public readonly string[] allVowels = { "iː", "ɑː", "uː", "ɔː", "ɜː", "ɪ", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "a‍ʊ", "ə‍ʊ", "i‍ə", "e‍ə" };

        public readonly string[] EE = { "iː", "ɪ", "ɛ", "ə", "a‍ɪ", "i‍ə", "e‍ə" };

        public readonly string[] AR = { "ɑː", "ɔː", "ɜː", "æ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "e‍ə" };

        public readonly string[] OO = { "uː", "ɜː", "ʊ", "a‍ʊ", "ə‍ʊ" };

        public readonly string[] OR = { "ɑː", "ɔː", "ɜː", "ɒ", "ɛ", "ɔ‍ɪ", "ə‍ʊ", "e‍ə" };

        public readonly string[] IR = { "uː", "ɜː", "ɪ", "ʌ", "ɛ", "a‍ɪ", "ɔ‍ɪ", "e‍ə" };

        public readonly string[] I = { "iː", "ɑː", "ɜː", "ɪ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "i‍ə", "e‍ə" };

        public readonly string[] A = { "ɑː", "æ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "e‍ə" };

        public readonly string[] OOt = { "iː", "ɑː", "uː", "ɔː", "æ", "ʊ", "ɒ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "a‍ʊ", "ə‍ʊ", "e‍ə" };

        public readonly string[] O = { "uː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "a‍ʊ", "ə‍ʊ" };

        public readonly string[] U = { "ɑː", "uː", "ɔː", "ɜː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ" };

        public readonly string[] E = { "iː", "ɜː", "ɪ", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "i‍ə", "e‍ə" };

        public readonly string[] AH = { "ɑː", "ɜː", "ɪ", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "i‍ə", "e‍ə" };

        public readonly string[] AY = { "ɜː", "ɪ", "æ", "ʌ", "ə", "e‍ɪ", "a‍ɪ" };

        public readonly string[] EYE = { "iː", "ɜː", "ɪ", "æ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "e‍ə" };

        public readonly string[] OY = { "ɔː", "ʊ", "ɒ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ" };

        public readonly string[] OU = { "ɑː", "uː", "ɜː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ʊ", "ə‍ʊ", "e‍ə" };

        public readonly string[] OWE = { "uː", "ɔː", "ɜː", "ɒ", "ʌ", "ə", "ɔ‍ɪ", "a‍ʊ", "ə‍ʊ" };

        public readonly string[] EAR = { "iː", "ɜː", "ɪ", "ɛ", "ə", "a‍ɪ", "ɔ‍ɪ", "i‍ə", "e‍ə" };

        public readonly string[] AIR = { "ɑː", "ɔː", "ɜː", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "i‍ə", "e‍ə" };





    }
}
