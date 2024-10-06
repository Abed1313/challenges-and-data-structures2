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
        public int LeafSum(TNode node)
        {
            if (node == null)
            {
                return 0;   
            }
            if ((node.Left == null) && (node.Right == null))
            {
                return node.Value;
            }
            int left = LeafSum(node.Left);
            int right = LeafSum(node.Right);
            return left + right;
        }
        public int LargestLevelValue()
        {
            List<int> nodeCountsPerLevel = new List<int>();
            // Start by calling the helper method to calculate the count of nodes at each level
            LargestLevelValue(Root, 0, nodeCountsPerLevel);

            // Find the level with the maximum node count
            int maxLevel = 0;
            int maxNodes = nodeCountsPerLevel[0];

            for (int i = 1; i < nodeCountsPerLevel.Count; i++)
            {
                if (nodeCountsPerLevel[i] > maxNodes)
                {
                    maxNodes = nodeCountsPerLevel[i];
                    maxLevel = i;
                }
            }

            return maxLevel;
        }

        private void LargestLevelValue(TNode node, int level, List<int> nodeCountsPerLevel)
        {
            if (node == null) return;

            // If this is the first time visiting this level, initialize the count for the level
            if (level == nodeCountsPerLevel.Count)
            {
                nodeCountsPerLevel.Add(0);
            }

            // Increment the count for the current level
            nodeCountsPerLevel[level]++;

            // Recur for the left and right children
            LargestLevelValue(node.Left, level + 1, nodeCountsPerLevel);
            LargestLevelValue(node.Right, level + 1, nodeCountsPerLevel);
        }
    

    public void PrintRightView(TNode node)
        {
            if (node == null) return;

            TNode current = node.Left;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Right;  
            }
            while(current != null)
            {
                TNode temp = current;
                current = current.Right;

                if(current == null && temp.Left !=null)
                {
                    current = temp.Left;
                    current = current.Right;
                }
                if(current != null)
                {
                    Console.WriteLine(current.Value);
                }
            }
        }

        public void countTreeLevelAndNodes(TNode root)
        {

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
