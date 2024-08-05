using StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : StackClass
    {
        public static void DeleteMiddle(StackClass stack)
        {
            if (stack.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            int count = stack.Count();

            int midIndex = (count - 1) / 2;


            StackClass temp = new StackClass();

            for (int i = 0; i < midIndex; i++)
            {
                temp.Push(stack.Pop());
            }
            stack.Pop();

            while(!temp.IsEmpty())
            {
                stack.Push(temp.Pop());
            }
        }
    }
}
