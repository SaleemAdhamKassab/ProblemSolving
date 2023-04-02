using Lab;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            clsDblLinkedList<int> clsDBlinkedList = new clsDblLinkedList<int>();
            clsDBlinkedList.insertAtBeging(5);
            clsDBlinkedList.insertAtBeging(4);
            clsDBlinkedList.insertAtBeging(3);
            clsDBlinkedList.insertAtBeging(2);
            clsDBlinkedList.insertAtBeging(1);
            clsDBlinkedList.insertAtBeging(0);
            clsDBlinkedList.printList();


            Console.WriteLine();
            if (clsDBlinkedList.Find(0).Data == 0)
                Console.WriteLine("Node With Value (0) is Found");


            Console.WriteLine();
            Console.WriteLine("After Inserting 500 after Head");
            clsDBlinkedList.InsertAfter(clsDBlinkedList.Head, 500);
            clsDBlinkedList.printList();


            Console.WriteLine();
            Console.WriteLine("After Inserting 700 at End");
            clsDBlinkedList.InsertAtEnd(700);
            clsDBlinkedList.printList();


            Console.WriteLine();
            Console.WriteLine("After Deleting 4");
            clsDBlinkedList.DeleteNode(4);
            clsDBlinkedList.printList();


            Console.WriteLine();
            Console.WriteLine("After Deleting First Node");
            clsDBlinkedList.DeleteFirstNode();
            clsDBlinkedList.printList();


            Console.WriteLine();
            Console.WriteLine("After Deleting Last Node");
            clsDBlinkedList.DeleteLastNode();
            clsDBlinkedList.printList();
        }
    }
}
