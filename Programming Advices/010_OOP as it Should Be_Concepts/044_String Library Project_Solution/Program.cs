using Lab;
using Lab.Classes;

namespace lab
{
    class Program
    {
        public enum enWhatToCount { Small, Capital, All }

        static void Main()
        {
            SaleemString obj = new SaleemString("Saleem Kassab");

            // 1
            obj.Length();
            SaleemString.Length("saleem kassab");

            //2
            obj.CountWords();
            SaleemString.CountWords("saleem kassab");

            //3
            obj.capitalize();
            SaleemString.Capitalize("saleem kassab");

            //4
            obj.LowerFirstLetterOfEachWord();
            SaleemString.LowerFirstLetterOfEachWord("SALEEM KASSAB");

            //5
            obj.ToUpper();
            SaleemString.ToUpper("saleem kassab");

            //6
            obj.ToLower();
            SaleemString.ToLower("SALEEM KASSAB");

            //7
            obj.Invert();
            SaleemString.Invert("Saleem");

            //8
            SaleemString.CountLetters("Saleem(*&^*$(#)Kassab");

            //9
            SaleemString.CountLetters("Saleem(*&^*$(#)Kassab", (SaleemString.enWhatToCount)enWhatToCount.Capital);

            //10
            SaleemString.CountLetters("Saleem(*&^*$(#)Kassab", (SaleemString.enWhatToCount)enWhatToCount.Small);

            //11
            obj.CountSpecificLetter('s');
            SaleemString.CountSpecificLetter("saleem kassab", 's', false);

            //12
            obj.CountVowels();
            SaleemString.CountVowels("saleem kassab");

            //13
            obj.TrimLeft();
            SaleemString.TrimLeft("  saleem kassab");

            //14
            obj.TrimRight();
            SaleemString.TrimRight("  saleem kassab     ");

            //15
            obj.Trim();
            SaleemString.Trim("    saleem kassab   ");

            //16
            SaleemString.JoinArray(new string[] { "saleem", "kassab" }, " ");

            //17
            obj.Replace("e", "x");
            obj.ReplaceAll("e", "x");
            obj.Replace("E", "x", false);
            obj.ReplaceAll("E", "x", false);
            SaleemString.Replace("saleem", "e", "x");
            SaleemString.Replace("saleem", "E", "x", false);
            SaleemString.ReplaceAll("saleem", "e", "x");
            SaleemString.ReplaceAll("saleem", "E", "x", false);

            //18
            obj.RemovePunctuations();
            SaleemString.RemovePunctuations("Saleem, Kassab");

            //19
            SaleemString.Split("saleem kassab", ' ');

            //20
            SaleemString.ReverseWords("Welcome To Syria");
        }
    }
}
