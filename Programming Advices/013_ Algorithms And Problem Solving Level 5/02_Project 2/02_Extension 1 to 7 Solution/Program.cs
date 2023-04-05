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


            Console.WriteLine("===============================");
            Console.WriteLine("Extensions 1 to 7: ");
            Console.WriteLine();

            //1)
            Console.WriteLine("Node(2) is: {0}", clsMyQueue.getNodeByIndex(2));
            Console.WriteLine();

            //2)
            Console.WriteLine("Queue After Reverse: ");
            clsMyQueue.reverse();
            clsMyQueue.print();
            Console.WriteLine();


            //3
            Console.WriteLine("Queue after updating node(2) to 600: ");
            clsMyQueue.updateNodeByIndex(2, 600);
            clsMyQueue.print();
            Console.WriteLine();

            //4
            Console.WriteLine("Queue after inserting 800 after Node(2): ");
            clsMyQueue.insertAfterNodeIndex(2, 800);
            clsMyQueue.print();
            Console.WriteLine();

            //5
            Console.WriteLine("Queue after inserting 1000 at front: ");
            clsMyQueue.insertAtFront(1000);
            clsMyQueue.print();
            Console.WriteLine();

            //6
            Console.WriteLine("Queue after inserting 2000 at Back: ");
            clsMyQueue.insertAtBack(2000);
            clsMyQueue.print();
            Console.WriteLine();

            //7
            Console.WriteLine("Queue after clear: ");
            clsMyQueue.clear();
            clsMyQueue.print();
        }
    }
}
