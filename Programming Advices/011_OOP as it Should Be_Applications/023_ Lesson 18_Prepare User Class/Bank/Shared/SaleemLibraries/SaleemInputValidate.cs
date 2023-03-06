using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Classes
{
    internal class SaleemInputValidate
    {
        public static bool IsNumberBetween(int number, int from, int to) => number >= from && number <= to;
        public static bool IsNumberBetween(double number, double from, double to) => number >= from && number <= to;
        public static bool IsDouble(string valueToTest)
        {
            if (double.TryParse(valueToTest, out double d) && !Double.IsNaN(d) && !Double.IsInfinity(d))
            {
                return true;
            }

            return false;
        }
        public static double readNumber()
        {
            string inputNumber = Console.ReadLine();

            while (!IsDouble(inputNumber))
            {
                Console.Write("Invalid Number, Enter a gain:");
                inputNumber = Console.ReadLine();
            }

            return double.Parse(inputNumber);
        }

        public static double readNumberBetween(double number, double from, double to)
        {
            while (!IsNumberBetween(number,from,to))
            {
                number = double.Parse(Console.ReadLine());
                Console.WriteLine("Number is not within range {0} and {1}: ", from, to);
            }

            return number;
        }

    }
}
