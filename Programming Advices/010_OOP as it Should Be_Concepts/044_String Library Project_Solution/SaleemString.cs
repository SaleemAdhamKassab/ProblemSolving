using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Classes
{
    internal class SaleemString
    {
        private string _userInput { get; set; }

        public SaleemString() { }
        public SaleemString(string userInput) => _userInput = userInput;

        //Shared
        static bool IsCharacter(char c) => ((int)c >= 97 && (int)c <= 122) || ((int)c >= 65 && (int)c <= 90) ? true : false;
        static bool isUpper(char c) => c == ToUpper(c);
        static char ToUpper(char c) => (int)c >= 97 && (int)c <= 122 ? (char)((int)c - 32) : c;
        static char ToLower(char c) => (int)c >= 65 && (int)c <= 90 ? (char)((int)c + 32) : c;
        static char InvertCase(char character) => character == ToLower(character) ? ToUpper(character) : ToLower(character);
        static string capitalizeWord(string word)
        {
            string result = isUpper(word[0]) ? word[0].ToString() : ToUpper(word[0]).ToString();

            for (int i = 1; i < word.Length; i++)
            {
                if (isUpper(word[i]))
                    result += ToLower(word[i]);
                else
                    result += word[i];
            }

            return result;
        }
        //////////

        //1
        public static int length(string s)
        {
            int i = 0;
            char c = ' ';

            while (true)
            {
                try
                {
                    c = s[i];
                    i++;
                }
                catch
                {
                    return i;
                }
            }
        }
        public int length() => length(_userInput);

        //2
        public static int countWords(string s)
        {
            bool isStartedWord = true;
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && isStartedWord)
                    counter++;

                isStartedWord = s[i] == ' ' ? true : false;

            }
            return counter;
        }
        public int countWords() => countWords(_userInput);

        //3
        public static string capitalizeFirstLetterOfEachWord(string s)
        {
            string result = "", word = "";
            s += " ";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    result += capitalizeWord(word);
                    if (i < s.Length - 2)
                        result += ' ';
                    word = "";
                }
                else
                {
                    word += s[i];
                }
            }

            return result;
        }
        public string capitalizeFirstLetterOfEachWord() => capitalizeFirstLetterOfEachWord(_userInput);

        //4
        public static string lowerFirstLetterOfEachWord(string word)
        {
            string result = "";
            bool isFirstLetter = true;


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ' && isFirstLetter)
                    result += ToLower(word[i]);
                else
                    result += word[i];


                isFirstLetter = word[i] == ' ' ? true : false;
            }

            return result;
        }
        public string lowerFirstLetterOfEachWord() => lowerFirstLetterOfEachWord(_userInput);

        //5
        public static string ToUpper(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
                if (IsCharacter(s[i]))
                    result += ToUpper(s[i]);
                else
                    result += s[i];

            return result;
        }
        public string ToUpper() => ToUpper(_userInput);

        //6
        public static string ToLower(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
                if (IsCharacter(s[i]))
                    result += ToLower(s[i]);
                else
                    result += s[i];

            return result;
        }
        public string ToLower() => ToLower(_userInput);

        //7
        public static string Invert(string s)
        {
            string invertedString = "";
            for (int i = 0; i < s.Length; i++)
                invertedString += InvertCase(s[i]);

            return invertedString;
        }
        public string Invert() => Invert(_userInput);

    }
}