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
        //Remove the first node with the specified data from the linkedlist.
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
        // Check if the linked List contains a node with the specified value.
        public void Inclode(int data)
        {
            if (First == null) return;

            if (First.Data == data)
            {
                First = First.Next;
                return;
            }
            Node current = First;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    Console.WriteLine("this is the data: " + data);
                    break;
                }
                current = current.Next;

            }
                if(current.Next == null)
                {
                    Console.WriteLine("not founde");
                }
            
        }
        //Print the contents of the list in order.
        public void DisplayList()
        {
            Node current = First;
            while (current != null)
            {
                current.DesplayData();
                current = current.Next;
            }
        }
        public int GetLength()
        {
            int length = 0;
            Node current = First;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }
    }
}
