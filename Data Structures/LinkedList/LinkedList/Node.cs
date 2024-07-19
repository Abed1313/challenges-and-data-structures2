namespace LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void DisplayData()
        {
            Console.Write(Data + " ");
        }
    }
}
