using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s = new MyString();

            Console.WriteLine("Undo/Redo Project");
            Console.WriteLine();

            s.value = "saleem1";
            s.printValue();

            s.value = "saleem2";
            s.printValue();

            s.value = "saleem3";
            s.printValue();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("_____ Undo _____");
            s.undo();
            s.printValue();
            s.undo();
            s.printValue();


            Console.WriteLine();
            Console.WriteLine("_____ Redo _____");
            s.redo();
            s.printValue();
            s.redo();
            s.printValue();
        }
    }
}
