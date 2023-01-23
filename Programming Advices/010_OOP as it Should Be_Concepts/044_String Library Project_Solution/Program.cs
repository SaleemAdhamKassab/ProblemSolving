using Lab;
using Lab.Classes;

namespace lab
{
    class Program
    {
        static void Main()
        {

            SaleemString obj = new SaleemString("Saleem Kassab");


            // 1
            obj.length();
            SaleemString.length("saleem kassab");

            //2
            obj.countWords();
            SaleemString.countWords("saleem kassab");

            //3
            obj.capitalizeFirstLetterOfEachWord();
            SaleemString.capitalizeFirstLetterOfEachWord("saleem kassab");

            //4
            obj.lowerFirstLetterOfEachWord();
            SaleemString.lowerFirstLetterOfEachWord("SALEEM KASSAB");


            //5
            obj.ToUpper();
            SaleemString.ToUpper("saleem kassab");

            //6
            obj.ToLower();
            SaleemString.ToLower("SALEEM KASSAB");

            //7
            obj.Invert();
            SaleemString.Invert("Saleem");



            Console.WriteLine(obj.Invert());
        }
    }
}