using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMyStack<int> clsMyStack = new clsMyStack<int>();

            clsMyStack.push(10);
            clsMyStack.push(20);
            clsMyStack.push(30);
            clsMyStack.push(40);
            clsMyStack.push(50);

            Console.WriteLine("My Stack is: ");
            clsMyStack.print();

            Console.WriteLine("Stack Size is: {0}", clsMyStack.size());
            Console.WriteLine("Stack Top is: {0}", clsMyStack.front());
            Console.WriteLine("Stack Bottom is: {0}", clsMyStack.back());

            Console.WriteLine();
            Console.WriteLine("Stack After pop(): ");
            clsMyStack.pop();
            clsMyStack.print();


            Console.WriteLine("===============================");
            Console.WriteLine("Extensions 1 to 7: ");
            Console.WriteLine();

            //1)
            Console.WriteLine("Node(2) is: {0}", clsMyStack.getNodeByIndex(2));
            Console.WriteLine();

            //2)
            Console.WriteLine("Stack After Reverse: ");
            clsMyStack.reverse();
            clsMyStack.print();
            Console.WriteLine();


            //3
            Console.WriteLine("Stack after updating node(2) to 600: ");
            clsMyStack.updateNodeByIndex(2, 600);
            clsMyStack.print();
            Console.WriteLine();

            //4
            Console.WriteLine("Stack after inserting 800 after Node(2): ");
            clsMyStack.insertAfterNodeIndex(2, 800);
            clsMyStack.print();
            Console.WriteLine();

            //5
            Console.WriteLine("Stack after inserting 1000 at front: ");
            clsMyStack.insertAtFront(1000);
            clsMyStack.print();
            Console.WriteLine();

            //6
            Console.WriteLine("Stack after inserting 2000 at Back: ");
            clsMyStack.insertAtBack(2000);
            clsMyStack.print();
            Console.WriteLine();

            //7
            Console.WriteLine("Stack after clear: ");
            clsMyStack.clear();
            clsMyStack.print();
        }
    }
}
