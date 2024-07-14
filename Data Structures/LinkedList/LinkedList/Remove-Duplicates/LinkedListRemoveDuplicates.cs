using System;

namespace LinkedList
{
    public static class LinkedListRemoveDuplicates
    {
        public static void RemoveDuplicate(LinkedListt linkedList)
        {
            Node current = linkedList.First;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }
    }
}
