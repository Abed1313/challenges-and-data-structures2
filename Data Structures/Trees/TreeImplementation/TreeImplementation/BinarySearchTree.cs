using System;

namespace TreeImplementation
{
    public class BinarySearchTree
    {
        public TNode Root { get; set; }

        public BinarySearchTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }

        public void Add(int value)
        {
            Root = Add(Root, value);
        }

        public static TNode Add(TNode node, int value)
        {
            if (node == null)
                return new TNode(value);

            // Duplicates not allowed
            if (value == node.Value)
                return node;

            if (value < node.Value)
                node.Left = Add(node.Left, value);
            else if (value > node.Value)
                node.Right = Add(node.Right, value);

            return node;
        }
        //*****************************************************************************************************
        public bool Contains(int value)
        {
            return Contains(Root, value) != null;
        }

        public static TNode Contains(TNode node, int value)
        {
            // Base Cases: root is null or key is present at root
            if (node == null || node.Value == value)
                return node;

            // Key is greater than root's key
            if (node.Value < value)
                return Contains(node.Right, value);

            // Key is smaller than root's key
            return Contains(node.Left, value);
        }
        //*****************************************************************************************************
        public void Delete(int value)
        {
            Root = DeleteNode(Root, value);
        }

        public static TNode DeleteNode(TNode root, int x)
        {
            // Base case
            if (root == null)
            {
                return null;
            }

            // If key to be deleted is in a left subtree
            if (x < root.Value)
            {
                root.Left = DeleteNode(root.Left, x);
            }
            // If key to be deleted is in a right subtree
            else if (x > root.Value)
            {
                root.Right = DeleteNode(root.Right, x);
            }
            // If root matches with the given key
            else
            {
                // Case when root has no children or only right child
                if (root.Left == null)
                {
                    return root.Right;
                }

                // Case when root has only left child
                if (root.Right == null)
                {
                    return root.Left;
                }

                // Case when both children are present
                TNode succ = GetSuccessor(root);
                root.Value = succ.Value;
                root.Right = DeleteNode(root.Right, succ.Value);
            }

            return root;
        }

        public static TNode GetSuccessor(TNode node)
        {
            TNode succ = node.Right;
            while (succ != null && succ.Left != null)
            {
                succ = succ.Left;
            }
            return succ;
        }

        // ( Left - Root - right )
        public void InOrderTraversalBST(TNode node)
        {
            if (node == null) return;

            InOrderTraversalBST(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversalBST(node.Right);
        }
        public void PostOrderTraversalBST(TNode node)
        {
            if (node == null) return;

            PostOrderTraversalBST(node.Left);
            PostOrderTraversalBST(node.Right);
            Console.Write(node.Value + "  ");
        }
    }
}
