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
            if (clsDBlinkedList.getNodeByIndex(4) == null)
                Console.WriteLine("Out Of List Range!!");
            else
                Console.WriteLine("Node Value is: {0}", clsDBlinkedList.getNodeByIndex(4).Data);

        }
    }
}
