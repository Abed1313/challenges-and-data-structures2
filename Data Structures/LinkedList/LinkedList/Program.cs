

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();
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
