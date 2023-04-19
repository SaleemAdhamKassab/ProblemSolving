using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueueArr<int> myQueueArr = new MyQueueArr<int>();

            myQueueArr.push(10);
            myQueueArr.push(20);
            myQueueArr.push(30);
            myQueueArr.push(40);
            myQueueArr.push(50);

            Console.WriteLine("My Queue is: ");
            myQueueArr.print();
            Console.WriteLine();

            Console.WriteLine("Queue Size is: {0}", myQueueArr.size());
            Console.WriteLine("Queue Front is: {0}", myQueueArr.front());
            Console.WriteLine("Queue Back is: {0}", myQueueArr.back());
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Queue After pop(): ");
            myQueueArr.pop();
            myQueueArr.print();


            Console.WriteLine("===============================");
            Console.WriteLine("Extensions 1 to 7: ");
            Console.WriteLine();

            //1)
            Console.WriteLine("Node(2) is: {0}", myQueueArr.getNodeByIndex(2));
            Console.WriteLine();

            //2)
            Console.WriteLine("Queue After Reverse: ");
            myQueueArr.reverse();
            myQueueArr.print();
            Console.WriteLine();


            //3
            Console.WriteLine("Queue after updating node(2) to 600: ");
            myQueueArr.updateNodeByIndex(2, 600);
            myQueueArr.print();
            Console.WriteLine();

            //4
            Console.WriteLine("Queue after inserting 800 after Node(2): ");
            myQueueArr.insertAfterNodeIndex(2, 800);
            myQueueArr.print();
            Console.WriteLine();

            //5
            Console.WriteLine("Queue after inserting 1000 at front: ");
            myQueueArr.insertAtFront(1000);
            myQueueArr.print();
            Console.WriteLine();

            //6
            Console.WriteLine("Queue after inserting 2000 at Back: ");
            myQueueArr.insertAtBack(2000);
            myQueueArr.print();
            Console.WriteLine();

            //7
            Console.WriteLine("Queue after clear: ");
            myQueueArr.clear();
            myQueueArr.print();
        }
    }
}
