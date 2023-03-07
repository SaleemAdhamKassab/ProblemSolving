using Lab.Class.Bank;
using Lab.Bank.Db;
using Lab.Bank.Shared;

namespace Lab.Bank.Screens
{
    public class Screen : SharedBusiness
    {
        private static void _centerText(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
      
        protected static void drawScreenHeader(string Title, string SubTitle = "")
        {
            Console.Clear();
            Console.WriteLine();
            _centerText(getBreakLine("*"));
            _centerText(Title);
            if (SubTitle != null)
                _centerText(SubTitle);
            _centerText(getBreakLine("*"));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}