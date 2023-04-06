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

            myDynamicArray.printList();

        }
    }
}
