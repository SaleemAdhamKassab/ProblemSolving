using Lab;
using Lab.DS;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDynamicArray<int> myDynamicArray = new MyDynamicArray<int>(5);
            myDynamicArray.setItem(0, 10);
            myDynamicArray.setItem(1, 20);
            myDynamicArray.setItem(2, 30);
            myDynamicArray.setItem(3, 40);
            myDynamicArray.setItem(4, 50);

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();

            Console.WriteLine("Array Elements:");
            myDynamicArray.printList();
            Console.WriteLine();


            Console.WriteLine("Array After Resize:");
            myDynamicArray.resize(6);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();

            Console.WriteLine("Item by index (2) is: {0}", myDynamicArray.getItemByIndex(2));
            Console.WriteLine();

            Console.WriteLine("Array Items After Reverse: ");
            myDynamicArray.reverse();
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Items after Deleting Item By Index (2):");
            myDynamicArray.deleteItemByIndex(2);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();

            
            
            Console.WriteLine("Array Items After Deleting First Item:");
            myDynamicArray.deleteFirstItem();
            myDynamicArray.printList();
            Console.WriteLine();


            Console.WriteLine("Array Items After Deleting Last Item:");
            myDynamicArray.deleteLastItem();
            myDynamicArray.printList();
            Console.WriteLine();


            int itemIndex = myDynamicArray.getItemIndex(30);
            if(itemIndex==-1)
                Console.WriteLine("Item 30 ws not Found!!");
            else
                Console.WriteLine("Item 30 was found at Index: {0}",itemIndex);

            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();

            Console.WriteLine("Array After Deleting Item(30): ");
            myDynamicArray.deleteItem(30);
            myDynamicArray.printList();
            Console.WriteLine();

            myDynamicArray.printList();
            Console.WriteLine("Array After Inserting 500 at Index(1): ");
            myDynamicArray.insertElementAtIndex(1, 500);
            myDynamicArray.printList();


            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();


            Console.WriteLine("Array After Inserting 400 at Begining: ");
            myDynamicArray.insertElementAtBegining(400);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();


            Console.WriteLine("Array After Inserting 1500 Before Index(2): ");
            myDynamicArray.insertBeforeIndex(2,1500);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();


            Console.WriteLine("Array After Inserting 2500 After Index(2): ");
            myDynamicArray.insertAfterIndex(2, 2500);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();

            Console.WriteLine("Array After Inserting 8000 At The End: ");
            myDynamicArray.insertElementAtEnd(8000);
            myDynamicArray.printList();
            Console.WriteLine();

            Console.WriteLine("Array Size is: {0}", myDynamicArray.size());
            Console.WriteLine();



            Console.WriteLine("Array Items after clear:");
            myDynamicArray.clear();
            myDynamicArray.printList();
            Console.WriteLine();


        }
    }
}
