using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {

            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

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


            singlyLinkedList.insertAfterNode(singlyLinkedList.Head, 500);
            Console.WriteLine("After Inserting (500) after The first Node:");
            singlyLinkedList.printList();
            Console.WriteLine();


            Console.WriteLine("Check if (5) in the List: ");
            if (singlyLinkedList.find(5).Data == -999)
                Console.WriteLine("Not Found Node With Data: 5");
            else
                Console.WriteLine("Founded Node With Data: 5");

        }
    }
}
