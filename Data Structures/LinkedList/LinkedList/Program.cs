namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Node nodeA = new Node();
            //nodeA.Data = 1;

            //Node nodeB = new Node();
            //nodeB.Data = 2;

            //Node nodeC = new Node();
            //nodeC.Data = 3;

            //Node nodeD = new Node();
            //nodeD.Data = 4;

            //nodeA.Next = nodeB;
            //nodeB.Next = nodeC;
            //nodeC.Next = nodeD;

            LinkedList linkedList = new LinkedList();
            linkedList.INsertFirst(1);
            linkedList.INsertFirst(2);
            linkedList.INsertFirst(3);
            linkedList.INsertFirst(4);

            linkedList.DeleteSpecifiedData(2);
            linkedList.Remove(3);




            linkedList.DisplayList();

        }
    }
}
