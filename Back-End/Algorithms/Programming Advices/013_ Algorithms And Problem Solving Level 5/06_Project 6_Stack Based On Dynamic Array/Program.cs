using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStackArr<int> MyStackArr = new MyStackArr<int>();

            MyStackArr.push(10);
            MyStackArr.push(20);
            MyStackArr.push(30);
            MyStackArr.push(40);
            MyStackArr.push(50);

            Console.WriteLine("My Stack is: ");
            MyStackArr.print();

            Console.WriteLine("Stack Size is: {0}", MyStackArr.size());
            Console.WriteLine("Stack Top is: {0}", MyStackArr.top());
            Console.WriteLine("Stack Bottom is: {0}", MyStackArr.bottom());

            Console.WriteLine();
            Console.WriteLine("Stack After pop(): ");
            MyStackArr.pop();
            MyStackArr.print();


            Console.WriteLine("===============================");
            Console.WriteLine("Extensions 1 to 7: ");
            Console.WriteLine();

            //1)
            Console.WriteLine("Node(2) is: {0}", MyStackArr.getNodeByIndex(2));
            Console.WriteLine();

            //2)
            Console.WriteLine("Stack After Reverse: ");
            MyStackArr.reverse();
            MyStackArr.print();
            Console.WriteLine();


            //3
            Console.WriteLine("Stack after updating node(2) to 600: ");
            MyStackArr.updateNodeByIndex(2, 600);
            MyStackArr.print();
            Console.WriteLine();

            //4
            Console.WriteLine("Stack after inserting 800 after Node(2): ");
            MyStackArr.insertAfterNodeIndex(2, 800);
            MyStackArr.print();
            Console.WriteLine();

            //5
            Console.WriteLine("Stack after inserting 1000 at front: ");
            MyStackArr.insertAtFront(1000);
            MyStackArr.print();
            Console.WriteLine();

            //6
            Console.WriteLine("Stack after inserting 2000 at Back: ");
            MyStackArr.insertAtBack(2000);
            MyStackArr.print();
            Console.WriteLine();

            //7
            Console.WriteLine("Stack after clear: ");
            MyStackArr.clear();
            MyStackArr.print();
        }
    }
}
