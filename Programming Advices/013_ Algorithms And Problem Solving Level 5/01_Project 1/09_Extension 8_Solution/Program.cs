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
            if (clsDBlinkedList.isNumberOutOfListrange(2))
                Console.WriteLine("Out Of List Range!!");
            else
            {
                clsDBlinkedList.insertAfter(2, 500);
                Console.WriteLine("After Inserting (500) After Node Index (2): ");
                clsDBlinkedList.printList();
            }
                

        }
    }
}
