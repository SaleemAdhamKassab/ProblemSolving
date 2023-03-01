namespace Labs.Bank.Screens
{
    public class Screen
    {
        private static void _centerText(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
        private static void _printmenuLine()
        {
            Console.Write("\t\t\t\t\t");
            printBreakLine("=", 35);
        }
        protected static void drawScreenHeader(string Title, string SubTitle = "")
        {
            _printmenuLine();
            _centerText(Title);
            if (SubTitle != null)
                _centerText(SubTitle);
            _printmenuLine();
        }
        public static void goBack()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back Menue...");
            Console.ReadKey();
        }
        public static void printBreakLine(string lineType, int rowLength) => Console.WriteLine(padRight(lineType, rowLength, char.Parse(lineType)));
        public static string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
    }
}
