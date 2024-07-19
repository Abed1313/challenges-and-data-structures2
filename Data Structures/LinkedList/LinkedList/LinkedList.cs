using LinkedList;
using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedListt
    {
        public Node Head { get; set; }

        public void InsertFirst(int data)
        {
            Node newNode = new Node
            {
                Data = data,
                Next = Head
            };
            Head = newNode;
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node
            {
                Data = data
            };

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void MergeSort(Node list1, Node list2)
        {
            if (list1 == null)
            {
                Head = list2;
                return;
            }
            if (list2 == null)
            {
                Head = list1;
                return;
            }
            Node MergedHead;
            if (list1.Data <= list2.Data)
            {
                MergedHead = list1;
                list1 = list1.Next;
            }
            else
            {
                MergedHead = list2;
                list2 = list2.Next;
            }
            Node current = MergedHead;
            while (list1 != null && list2 != null)
            {
                if (list1.Data <= list2.Data)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }
                current = current.Next;
            }
            if (list1 != null)
            {
                current.Next = list1;
            }
            else
            {
                current.Next = list2;
            }
            Head = MergedHead;
        }

        public void RemoveDuplicate()
        {
            Node current = Head;
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

        public void DeleteSpecifiedData(int data)
        {
            Node temp = Head;
            Node prev = null;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    if (prev == null)
                    {
                        Head = temp.Next;
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

        public void Include(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    Console.WriteLine("This is the data: " + data);
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Not found");
        }

        public void DisplayList()
        {
            Node current = Head;
            while (current != null)
            {
                current.DisplayData();
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int GetLength()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public int[] GetLinkedListData(LinkedListt linkedList)
        {
            var current = Head;
            var result = new List<int>();

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Next;
            }

            return result.ToArray();
        }
    }
}
