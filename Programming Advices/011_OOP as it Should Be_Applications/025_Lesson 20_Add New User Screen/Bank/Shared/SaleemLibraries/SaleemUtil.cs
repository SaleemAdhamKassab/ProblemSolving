using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Classes
{
    internal class SaleemUtil
    {
        //Shared
        public enum enRandomCharacters { smallLetter, capitalLetter, specialChar, digit, mix }
        static int Length(string s)
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
        ///

        //1
        public static int generateRandomNumber(int from, int to)
        {
            Random rnd = new Random();
            return rnd.Next(from, to);
        }

        //2
        public static char getRandomChar(enRandomCharacters randomChar)
        {
            if (randomChar == enRandomCharacters.capitalLetter)
                return ((char)generateRandomNumber(65, 90));
            else if (randomChar == enRandomCharacters.smallLetter)
                return ((char)generateRandomNumber(97, 122));
            else if (randomChar == enRandomCharacters.digit)
                return ((char)generateRandomNumber(48, 57));
            else if (randomChar == enRandomCharacters.specialChar)
                return ((char)generateRandomNumber(33, 47));
            else
                return ((char)generateRandomNumber(33, 122));
        }

        //3
        public static string generateRandomWord(enRandomCharacters charsTypes, int length)
        {
            string randomWord = "";

            for (int i = 0; i < length; i++)
                randomWord += getRandomChar(charsTypes);

            return randomWord;
        }

        //4
        public static string generateKey(enRandomCharacters charsTypes, int keysNumber)
        {
            string key = "";

            key += generateRandomWord(charsTypes, 4) + '-';
            key += generateRandomWord(charsTypes, 4) + '-';
            key += generateRandomWord(charsTypes, 4) + '-';
            key += generateRandomWord(charsTypes, 4);

            return key;
        }

        //5
        public static string[] generateKeys(enRandomCharacters charsTypes, int keysNumber)
        {
            string[] keys = new string[keysNumber];

            for (int i = 0; i < keysNumber; i++)
                keys[i] = generateKey(charsTypes, 4);

            return keys;
        }

        //6
        public static void printStrArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        public static void printIntArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine(" ]");
        }

        //7
        static void swapTwoParams(ref object param1, ref object param2)
        {
            object temp = param1;

            param1 = param2;
            param2 = temp;
        }

        //8
        public static int[] generteRandomNumbersArray(int arrLength, int from, int to)
        {
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
                arr[i] = generateRandomNumber(from, to);

            return arr;
        }

        //9
        public static string[] generteRandomWordsArray(enRandomCharacters charsType, int arrLength, int wordLength)
        {
            string[] arr = new string[arrLength];

            for (int i = 0; i < arrLength; i++)
                arr[i] = generateRandomWord(charsType, wordLength);

            return arr;
        }

        //10
        public static void tabs(int tabsCount)
        {
            for (int i = 0; i < tabsCount; i++)
                Console.Write("\t");
        }

        //11
        static char encryptTextMethod(char textChar, short encryptionKey) =>
            (char)((int)(textChar) + encryptionKey);
        public static string encryptText(string text)
        {
            string encryptText = "";

            for (int i = 0; i < text.Length; i++)
            {
                encryptText += encryptTextMethod(text[i], 2);
            }
            return encryptText;
        }

        //12
        static char decryptTextMethod(char decryptedChar, short encryptionKey) =>
            (char)((int)(decryptedChar) - encryptionKey);
        public static string decryptText(string decryptionText)
        {
            string dencryptText = "";

            for (int i = 0; i < decryptionText.Length; i++)
            {
                dencryptText += decryptTextMethod(decryptionText[i], 2);
            }
            return dencryptText;
        }

        //13
        public static string NumberToText(int Number)
        {

            if (Number == 0)
            {
                return "";
            }

            if (Number >= 1 && Number <= 19)
            {
                string[] arr = { "", "One","Two","Three","Four","Five","Six","Seven",
                                              "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen",
                                               "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen" };
                return arr[Number] + " ";
            }

            if (Number >= 20 && Number <= 99)
            {
                string[] arr = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                return arr[Number / 10] + " " + NumberToText(Number % 10);
            }

            if (Number >= 100 && Number <= 199)
            {
                return "One Hundred " + NumberToText(Number % 100);
            }

            if (Number >= 200 && Number <= 999)
            {
                return NumberToText(Number / 100) + "Hundreds " + NumberToText(Number % 100);
            }

            if (Number >= 1000 && Number <= 1999)
            {
                return "One Thousand " + NumberToText(Number % 1000);
            }

            if (Number >= 2000 && Number <= 999999)
            {
                return NumberToText(Number / 1000) + "Thousands " + NumberToText(Number % 1000);
            }

            if (Number >= 1000000 && Number <= 1999999)
            {
                return "One Million " + NumberToText(Number % 1000000);
            }

            if (Number >= 2000000 && Number <= 999999999)
            {
                return NumberToText(Number / 1000000) + "Millions " + NumberToText(Number % 1000000);
            }

            if (Number >= 1000000000 && Number <= 1999999999)
            {
                return "One Billion " + NumberToText(Number % 1000000000);
            }
            else
            {
                return NumberToText(Number / 1000000000) + "Billions " + NumberToText(Number % 1000000000);
            }
        }
    }
}