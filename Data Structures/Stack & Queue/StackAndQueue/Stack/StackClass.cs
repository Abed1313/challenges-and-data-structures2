﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Stack
{
    public class StackClass
    {
        private Node top;
        
        public StackClass()
        {
            top = null;
        }
        public int Count()
        {
            int count = 0;
            Node current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        // Push method
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        // Pop method
        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            int data = top.Data;
            top = top.Next;
            return data;
        }

        // Peek method
        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return top.Data;
        }

        // IsEmpty method
        public bool IsEmpty()
        {
            return top == null;
        }

        // Print Method
        public void PrintStack()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
