using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBook.Model
{
    public static class AmbiguityRules
    {
        // T - t, d, the, think
        public static string[] T = { "t", "d", "ð", "θ" };

        // F - f, v
        public static string[] F = { "f", "v" };

        // B - b, v, p
        public static string[] B = { "b", "v", "p" };

        // D - d, th, z, d3, 3, t, th, 
        public static string[] D = { "d", "ð", "z", "d‍ʒ", "ʒ", "t", "θ" };

        // G - g, k,
        public static string[] G = { "ɡ", "k" };

        // V - v, b, j, w, f
        public static string[] V = { "v", "b", "j", "w", "f" };

        // THe - th, d, z, d3, t, th
        public static string[] THe = { "ð", "d", "z", "d‍ʒ", "t", "θ" };



        // Z - z, 3, d3, s, sh, ch
        public static string[] Z = { "z", "ʒ", "d‍ʒ", "s", "ʃ", "tʃ" };

        // 3 - 3, d3, j, s, sh
        public static string[] SJ = { "ʒ", "d‍ʒ", "j", "s", "ʃ" };

        // d3 - d3, 3, d, ch
        public static string[] DJ = { "d‍ʒ", "ʒ", "d", "tʃ" };

        // L - l, r, w
        public static string[] L = { "l", "ɹ", "w" };

        // R - r, l, v, w
        public static string[] R = { "ɹ", "l", "v", "w" };

        // J - j, 3, d3, w
        public static string[] J = { "j", "ʒ", "d‍ʒ", "w" };

        // W - w, v, r
        public static string[] W = { "w", "v", "ɹ" };

        // M - m, b
        public static string[] M = { "m", "b" };

        // N - n, d, ng
        public static string[] N = { "n", "d", "ŋ" };

        // NG - ng, n
        public static string[] NG = { "ŋ", "n" };

        // P - p, b, v, m
        public static string[] P = { "p", "b", "v", "m" };




        // K - k, g
        public static string[] K = { "k", "ɡ" };



        // THink - think, d, the, t, f, ch
        public static string[] THink = { "θ", "d", "ð", "t", "f", "tʃ" };

        // S - s, z, 3, d3, sh, ch 
        public static string[] S = { "s", "z", "ʒ", "d‍ʒ", "ʃ", "tʃ" };

        // SH - sh, 3, d3, ch
        public static string[] SH = { "ʃ", "ʒ", "d‍ʒ", "tʃ" };

        // CH - ch, 3, d3, t, sh
        public static string[] CH = { "tʃ", "ʒ", "d‍ʒ", "t", "ʃ" };

        //All consonants
        public static string[] allConsonants = { "b", "d", "ɡ", "v", "ð", "z", "ʒ", "d‍ʒ", "l", "ɹ", "j", "w", "m", "n", "ŋ", "p", "t", "k", "f", "θ", "s", "ʃ", "tʃ" };









        // All vowels
        public static string[] allVowels = { "iː", "ɑː", "uː", "ɔː", "ɜː", "ɪ", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "a‍ʊ", "ə‍ʊ", "i‍ə", "e‍ə" };

        public static string[] EE = { "iː", "ɪ", "ɛ", "ə", "a‍ɪ", "i‍ə", "e‍ə" };

        public static string[] AR = { "ɑː", "ɔː", "ɜː", "æ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "e‍ə" };

        public static string[] OO = { "uː", "ɜː", "ʊ", "a‍ʊ", "ə‍ʊ" };

        public static string[] OR = { "ɑː", "ɔː", "ɜː", "ɒ", "ɛ", "ɔ‍ɪ", "ə‍ʊ", "e‍ə" };

        public static string[] IR = { "uː", "ɜː", "ɪ", "ʌ", "ɛ", "a‍ɪ", "ɔ‍ɪ", "e‍ə" };

        public static string[] I = { "iː", "ɑː", "ɜː", "ɪ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ", "i‍ə", "e‍ə" };

        public static string[] A = { "ɑː", "æ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "e‍ə" };

        public static string[] OOt = { "iː", "ɑː", "uː", "ɔː", "æ", "ʊ", "ɒ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "a‍ʊ", "ə‍ʊ", "e‍ə" };

        public static string[] O = { "uː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "a‍ʊ", "ə‍ʊ" };

        public static string[] U = { "ɑː", "uː", "ɔː", "ɜː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ" };

        public static string[] E = { "iː", "ɜː", "ɪ", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "i‍ə", "e‍ə" };

        public static string[] AH = { "ɑː", "ɜː", "ɪ", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "i‍ə", "e‍ə" };

        public static string[] AY = { "ɜː", "ɪ", "æ", "ʌ", "ə", "e‍ɪ", "a‍ɪ" };

        public static string[] EYE = { "iː", "ɜː", "ɪ", "æ", "ɛ", "ə", "e‍ɪ", "a‍ɪ", "e‍ə" };

        public static string[] OY = { "ɔː", "ʊ", "ɒ", "ʌ", "ə", "e‍ɪ", "a‍ɪ", "ɔ‍ɪ" };

        public static string[] OU = { "ɑː", "uː", "ɜː", "æ", "ʊ", "ɒ", "ʌ", "ɛ", "ə", "e‍ɪ", "a‍ʊ", "ə‍ʊ", "e‍ə" };

        public static string[] OWE = { "uː", "ɔː", "ɜː", "ɒ", "ʌ", "ə", "ɔ‍ɪ", "a‍ʊ", "ə‍ʊ" };

        public static string[] EAR = { "iː", "ɜː", "ɪ", "ɛ", "ə", "a‍ɪ", "ɔ‍ɪ", "i‍ə", "e‍ə" };

        public static string[] AIR = { "ɑː", "ɔː", "ɜː", "æ", "ʌ", "ɛ", "ə", "e‍ɪ", "i‍ə", "e‍ə" };





    }
}
