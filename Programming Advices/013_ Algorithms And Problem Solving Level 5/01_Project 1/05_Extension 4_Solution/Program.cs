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
            clsDBlinkedList.printList();

      
            Console.WriteLine();
            clsDBlinkedList.reverse();
            Console.WriteLine("Linked List Content After Reverse: ");
            clsDBlinkedList.printList();

        }
    }
}
