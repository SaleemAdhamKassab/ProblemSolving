using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMyQueue<int> clsMyQueue = new clsMyQueue<int>();

            clsMyQueue.push(10);
            clsMyQueue.push(20);
            clsMyQueue.push(30);
            clsMyQueue.push(40);
            clsMyQueue.push(50);

            Console.WriteLine("My Queue is: ");
            clsMyQueue.print();

            Console.WriteLine("Queue Size is: {0}", clsMyQueue.size());
            Console.WriteLine("Queue Front is: {0}", clsMyQueue.front());
            Console.WriteLine("Queue Back is: {0}", clsMyQueue.back());

            Console.WriteLine();
            Console.WriteLine("Queue After pop(): ");
            clsMyQueue.pop();
            clsMyQueue.print();


        }
    }
}
