using Lab.Class.Bank;
using Labs.Bank.Db;
using Labs.Bank.Shared;

namespace Labs.Bank.Screens
{
    public class Screen : SharedBusiness
    {
        private static void _centerText(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
        private static void _printMenuLine()
        {
            Console.Write("\t\t\t\t\t");
            printBreakLine("=", 35);
        }
        protected static void drawScreenHeader(string Title, string SubTitle = "")
        {
            _centerText(Title);
            if (SubTitle != null)
                _centerText(SubTitle);
        }
    }
}
