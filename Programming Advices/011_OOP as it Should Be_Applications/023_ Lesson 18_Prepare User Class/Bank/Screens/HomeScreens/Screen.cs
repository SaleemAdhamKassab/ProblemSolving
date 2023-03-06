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
        protected static void drawScreenHeader(string Title, string SubTitle = "")
        {
            Console.Clear();
            _centerText(Title);
            if (SubTitle != null)
                _centerText(SubTitle);
        }
    }
}