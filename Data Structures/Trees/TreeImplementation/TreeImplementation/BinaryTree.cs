using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root { get; set; }


        public BinaryTree(int rootValue)
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
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }

            else
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
        }
        public int FindSecondMax()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            if (Root.Left == null && Root.Right == null)
            {
                throw new InvalidOperationException("Tree has only one node");
            }

            return FindSecondMax(Root).Value;
        }

        private TNode FindSecondMax(TNode node)
        {
            // Traverse to the rightmost node
            TNode parent = null;
            while (node.Right != null)
            {
                parent = node;
                node = node.Right;
            }

            if (node.Left != null)
            {
                return FindMax(node.Left);
            }

            return parent;
        }

        private TNode FindMax(TNode node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node;
        }
        // ( Root - Left - Right )
        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return; // Base case if node null then return

            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);

        }

        // ( Left - Root - right )
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversal(node.Right);
        }

        // ( Left - Right - Root )
        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + "  ");
        }
    }
}
