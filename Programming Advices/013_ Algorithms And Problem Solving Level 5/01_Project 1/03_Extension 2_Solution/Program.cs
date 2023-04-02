using Lab;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            clsDblLinkedList<int> clsDBlinkedList = new clsDblLinkedList<int>();

            if(clsDBlinkedList.isEmpty())
                Console.WriteLine("Yes List is Empty");
            Console.WriteLine();

            clsDBlinkedList.insertAtBeging(5);
            clsDBlinkedList.insertAtBeging(4);
            clsDBlinkedList.insertAtBeging(3);
            clsDBlinkedList.insertAtBeging(2);
            clsDBlinkedList.insertAtBeging(1);
            clsDBlinkedList.printList();

      
            Console.WriteLine("Number of Items in Linked List is: {0}", clsDBlinkedList.size());

            Console.WriteLine();
            if (clsDBlinkedList.isEmpty())
                Console.WriteLine("No List is Not Empty");
        }
    }
}
