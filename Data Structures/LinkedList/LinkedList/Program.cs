

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedListt linkedList = new LinkedListt();
            linkedList.INsertFirst(2);
            linkedList.INsertFirst(2);
            linkedList.INsertFirst(3);
            linkedList.INsertFirst(4);
            linkedList.INsertFirst(4);

            // linkedList.DeleteSpecifiedData(2);
            linkedList.DisplayList();

            Console.WriteLine();

            LinkedListRemoveDuplicates.RemoveDuplicate(linkedList);

            linkedList.DisplayList();

            Console.WriteLine();

            //linkedList.Inclode(3);




            

        }
    }
}
