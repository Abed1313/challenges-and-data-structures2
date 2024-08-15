using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.MirrorTree
{
    public class MirrorTree
    {
        public TNode Root { get; set; }


        public MirrorTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }


        public void Insert(int value)
        {
            Insert(Root, value);
        }

        private void Insert(TNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }

            else
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
        }
        public List<int> InOrderTraversal2(TNode node)
        {
            List<int> result = new List<int>();
            InOrderTraversal2(node, result);
            return result;
        }
        // ( Left - Root - right )
        private void InOrderTraversal2(TNode node, List<int> result)
        {
            if (node == null) return;

            InOrderTraversal2(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal2(node.Right, result);
        }
        //public void InOrderTraversal2(TNode node)
        //{
        //    if (node == null) return;

        //    InOrderTraversal2(node.Left);
        //    Console.Write(node.Value + "  ");
        //    InOrderTraversal2(node.Right);
        //}
    }
}
