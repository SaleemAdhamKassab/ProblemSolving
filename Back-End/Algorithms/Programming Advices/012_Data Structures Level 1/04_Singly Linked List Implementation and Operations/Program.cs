using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MySinglyLinkedList<int> singlyLinkedList = new MySinglyLinkedList<int>();

            Console.WriteLine("Before Fill the List:");
            singlyLinkedList.printList();
            Console.WriteLine();


            singlyLinkedList.insertAtEnd(1);
            singlyLinkedList.insertAtEnd(2);
            singlyLinkedList.insertAtEnd(3);
            singlyLinkedList.insertAtEnd(4);
            singlyLinkedList.insertAtEnd(5);
            Console.WriteLine("After Fill The List:");
            singlyLinkedList.printList();
            Console.WriteLine();


            singlyLinkedList.insertAtBeging(0);
            Console.WriteLine("After Inserting (0) To The Begining of The List:");
            singlyLinkedList.printList();
            Console.WriteLine();


            singlyLinkedList.insertAfter(singlyLinkedList.Head, 500);
            Console.WriteLine("After Inserting (500) after The first Node:");
            singlyLinkedList.printList();
            Console.WriteLine();


            Console.WriteLine("Check if (5) in the List: ");
            if (singlyLinkedList.getNodeByData(5) == null)
                Console.WriteLine("Not Found Node With Data: 5");
            else
                Console.WriteLine("Founded Node With Data: 5");

            Console.WriteLine();

            Console.WriteLine("Node with index(2) is: {0}", singlyLinkedList.getNodeByIndex(2).Data);
            Console.WriteLine();

            Console.WriteLine("After Inserting 1000 after node Index(2):");
            singlyLinkedList.insertAfter(2, 1000);
            singlyLinkedList.printList();
            Console.WriteLine();

            Console.WriteLine("After Deleting Node(500): ");
            singlyLinkedList.deleteNodeByData(500);
            singlyLinkedList.printList();
            Console.WriteLine();

            Console.WriteLine("List After Clear:");
            singlyLinkedList.clear();
            singlyLinkedList.printList();

        }
    }
}
