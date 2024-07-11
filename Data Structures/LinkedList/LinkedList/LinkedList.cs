using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void INsertFirst(int data)
        {
            //Create the node 
            Node newNode = new Node();
            //Put the data in the node 
            newNode.Data = data;
            //Put the old date in the next
            newNode.Next = First;
            //Make the first the new node
            First = newNode;
        }
        //test 1 for delete
        public void DeleteSpecifiedData(int data)
        {
            //Assign The Temprory Variables
            Node temp = First;
            Node prev = null;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    if (prev == null)
                    {
                        First = temp.Next;
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }
                    return;
                }
                prev = temp;
                temp = temp.Next;
            }
        }
        //test 2 for delete
        public void Remove(int data)
        {
            if (First == null) return;

            if (First.Data == data)
            {
                First = First.Next;
                return;
            }
            Node current = First;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating thrw list...");
            Node current = First;
            while (current != null)
            {
                current.DesplayData();
                current = current.Next;
            }
        }
    }
}
