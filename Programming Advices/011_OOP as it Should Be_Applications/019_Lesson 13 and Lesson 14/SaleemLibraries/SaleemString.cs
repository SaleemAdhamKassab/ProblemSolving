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
        static bool IsLetter(char c) => c >= 97 && (int)c <= 122 || (int)c >= 65 && (int)c <= 90;
        static bool IsUpper(char c) => IsLetter(c) && c == ToUpper(c);
        static bool IsLower(char c) => IsLetter(c) && c == ToLower(c);
        static bool IsVowel(char character)
        {
            character = ToLower(character);

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;

                default:
                    return false;
            }
        }
        static bool IsPunctuation(char character)
        {
            switch (character)
            {
                case '.':
                case '?':
                case '\'':
                case ',':
                case '_':
                case '-':
                case '!':
                case ':':
                case '(':
                case ')':
                case '[':
                case ']':
                    return true;
                default:
                    return false;
            }
        }

        static char ToUpper(char c) => (int)c >= 97 && (int)c <= 122 ? (char)((int)c - 32) : c;
        static char ToLower(char c) => (int)c >= 65 && (int)c <= 90 ? (char)((int)c + 32) : c;

        static char InvertCase(char character) => character == ToLower(character) ? ToUpper(character) : ToLower(character);
        static string CapitalizeWord(string word)
        {
            string result = IsUpper(word[0]) ? word[0].ToString() : ToUpper(word[0]).ToString();

            for (int i = 1; i < word.Length; i++)
            {
                if (IsUpper(word[i]))
                    result += ToLower(word[i]);
                else
                    result += word[i];
            }

            return result;
        }
        //////////

        //1
        public static int Length(string s)
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
        public int Length() => Length(_userInput);

        //2
        public static int CountWords(string s)
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
        public int CountWords() => CountWords(_userInput);

        //3
        public static string Capitalize(string s)
        {
            string result = "", word = "";
            s += " ";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    result += CapitalizeWord(word);
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
        public string capitalize() => Capitalize(_userInput);

        //4
        public static string LowerFirstLetterOfEachWord(string word)
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
        public string LowerFirstLetterOfEachWord() => LowerFirstLetterOfEachWord(_userInput);

        //5
        public static string ToUpper(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
                if (IsLetter(s[i]))
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
                if (IsLetter(s[i]))
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


        //8   //9  //10
        public enum enWhatToCount { Small, Capital, All }
            public static int CountLetters(string s, enWhatToCount enWhatToCount = enWhatToCount.All)
            {
                int counter = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (IsLetter(s[i]))
                    {
                        if (enWhatToCount == enWhatToCount.Capital && IsUpper(s[i]))
                            counter++;

                        if (enWhatToCount == enWhatToCount.Small && IsLower(s[i]))
                            counter++;

                        if (enWhatToCount == enWhatToCount.All)
                            counter++;
                    }

                }
                return counter;
            }

        //11
        public static int CountSpecificLetter(string s, char letter, bool matchCase = true)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (matchCase && ToLower(s[i]) == ToLower(letter))
                    counter++;

                if (!matchCase && s[i] == letter)
                    counter++;
            }

            return counter;
        }
        public int CountSpecificLetter(char letter, bool matchCase = true) => CountSpecificLetter(_userInput, letter, matchCase);

        //12
        public static int CountVowels(string s)
        {
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
                if (IsVowel(s[i]))
                    counter++;

            return counter;
        }

        public int CountVowels() => CountVowels(_userInput);

        //13
        public static string TrimLeft(string s)
        {
            string result = "";
            bool stop = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && stop == false)
                    continue;
                else
                    stop = true;

                result += s[i];
            }

            return result;
        }
        public string TrimLeft() => TrimLeft(_userInput);

        //14
        static int lastCharIndex(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
                if (s[i] != ' ')
                    return i;
            return -1;
        }
        public static string TrimRight(string s)
        {
            string result = "";
            int lastIndex = lastCharIndex(s);

            for (int i = 0; i <= lastIndex; i++)
                result += s[i];

            return result;
        }
        public string TrimRight() => TrimRight(_userInput);

        //15
        public static string Trim(string s) => TrimRight(TrimLeft(s));
        public string Trim() => Trim(_userInput);

        //16
        public static string JoinArray(string[] arr, string delimiter = "")
        {
            string result = "";

            for (int i = 0; i < arr.Length - 1; i++)
                result += arr[i] + delimiter;

            result += delimiter + arr[arr.Length - 1];

            return result;
        }

        //17
        static int IndexOf(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if (needle.Length > haystack.Length) return -1;
            if (haystack == needle) return 0;

            int counter = 0, oldIndex = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                oldIndex = i;
                if (haystack[i] == needle[0] && i <= haystack.Length - needle.Length)
                {
                    if ((i == haystack.Length - 1) && (counter == needle.Length)) return i;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[i] == needle[j])
                        {
                            counter++;
                            i++;
                        }
                        else
                        {
                            i = oldIndex;
                            break;
                        }
                    }
                    if (counter == needle.Length) return oldIndex;
                    i = oldIndex;
                    counter = 0;
                }
            }
            return -1;
        }
        static string RemoveWithCount(string s, int startIndex, int count)
        {
            string result = "";

            for (int i = 0; i < startIndex; i++)
                result += s[i];

            for (int i = startIndex + count; i < s.Length; i++)
                result += s[i];

            return result;
        }
        static string InsertAtPosition(string s, int insertPostion, string stringToInsert)
        {
            string result = "";

            if (insertPostion == 0)
                return stringToInsert + s;
            if (insertPostion == s.Length)
                return s + stringToInsert;

            //insert inside
            for (int i = 0; i < insertPostion; i++)
                result += s[i];

            result += stringToInsert;

            for (int i = insertPostion; i < s.Length; i++)
                result += s[i];

            return result;
        }


        public static string Replace(string s, string stringToReplace, string sRepalceTo, bool matchCase = true)
        {
            int indexStringToReplace = -1;

            if (matchCase)
                indexStringToReplace = IndexOf(s, stringToReplace);
            else
                indexStringToReplace = IndexOf(SaleemString.ToLower(s), SaleemString.ToLower(stringToReplace));


            if (indexStringToReplace != -1)
            s = InsertAtPosition(RemoveWithCount(s, indexStringToReplace, stringToReplace.Length),
                                 indexStringToReplace, sRepalceTo);

            return s;
        }
        public string Replace(string stringToReplace, string sRepalceTo, bool matchCase = true)
            => Replace(_userInput, stringToReplace, sRepalceTo, matchCase);

        public static string ReplaceAll(string s, string stringToReplace, string sRepalceTo, bool matchCase = true)
        {
            if (!matchCase)
            {
                s = SaleemString.ToLower(s);
                stringToReplace = SaleemString.ToLower(stringToReplace);
            }

            while (IndexOf(s, stringToReplace) > -1)
                s = Replace(s, stringToReplace, sRepalceTo);

            return s;
        }
        public string ReplaceAll(string stringToReplace, string sRepalceTo, bool matchCase = true)
           => ReplaceAll(_userInput, stringToReplace, sRepalceTo, matchCase);

        //18
        public static string RemovePunctuations(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
                if (!IsPunctuation(s[i]))
                    result += s[i];

            return result;
        }
        public string RemovePunctuations() => RemovePunctuations(_userInput);

        //19
        static string[] ConvertListToArray(List<string> lst)
        {
            string[] result = new string[lst.Count];

            for (int i = 0; i < lst.Count; i++)
                result[i] = lst[i];

            return result;
        }
        public static string[] Split(string s, char delimeter)
        {
            string word = "";
            s += delimeter;

            List<string> splitedString = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != delimeter)
                    word += s[i];
                else
                {
                    splitedString.Add(word);
                    word = "";
                }
            }

            return ConvertListToArray(splitedString);
        }

        //20
        public static string ReverseWords(string s)
        {
            string result = "";
            string[] splitedString = s.Split(' ');

            for (int i = splitedString.Length - 1; i >= 0; i--)
                result += splitedString[i] + ' ';

            return TrimRight(result);
        }
    }
}