

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListt linkedList1 = new LinkedListt();
            linkedList1.InsertLast(2);
            linkedList1.InsertLast(5);
            linkedList1.InsertLast(7);
            linkedList1.InsertLast(8);
            linkedList1.InsertLast(9);

            LinkedListt linkedList2 = new LinkedListt();
            linkedList2.InsertLast(0);
            linkedList2.InsertLast(1);
            linkedList2.InsertLast(3);
            linkedList2.InsertLast(4);
            linkedList2.InsertLast(6);

            Console.WriteLine("List 1:");
            linkedList1.DisplayList();

            Console.WriteLine("List 2:");
            linkedList2.DisplayList();

            LinkedListt mergedList = new LinkedListt();
            mergedList.MergeSort(linkedList1.Head, linkedList2.Head);

            Console.WriteLine("Merged List:");
            mergedList.DisplayList();

            // linkedList.DeleteSpecifiedData(2);
            //linkedList.DisplayList();
            //LinkedListRemoveDuplicates.RemoveDuplicate(linkedList);
            //linkedList.Inclode(3);
        }
    }


    

}
    
