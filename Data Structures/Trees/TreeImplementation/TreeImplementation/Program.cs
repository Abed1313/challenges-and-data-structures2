namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BTree = new BinaryTree(10);

            BTree.Insert(5);
            BTree.Insert(18);
            BTree.Insert(3);
            BTree.Insert(7);
            BTree.Insert(15);

            // Pre Order Traversal
            Console.WriteLine("Pre Order Traversal");
            BTree.PreOrderTraversal(BTree.Root);
            Console.WriteLine("\n----------------------------");

            // In Order Traversal
            Console.WriteLine("In Order Traversal");
            BTree.InOrderTraversal(BTree.Root);
            Console.WriteLine("\n----------------------------");

            // Post Order Traversal
            Console.WriteLine("Post Order Traversal");
            BTree.PostOrderTraversal(BTree.Root);
            Console.WriteLine("\n----------------------------");

            /////////////////////////////////////// Binary Search Tree /////////////////////////////////////
            // Creating the following BST
            //      50
            //     /  \
            //    30   70
            //   / \   / \
            //  20 40 60 80
            BinarySearchTree BSTrre = new BinarySearchTree(50);

            BSTrre.Add(30);
            BSTrre.Add(20);
            BSTrre.Add(40);
            BSTrre.Add(70);
            BSTrre.Add(60);
            BSTrre.Add(80);
            BSTrre.InOrderTraversalBST(BSTrre.Root);
            Console.WriteLine();

            // Check if 40 exists in the tree
            Console.WriteLine(BSTrre.Contains(40) ? "Found" : "Not Found");
            
            // Delete 40 from the tree
            BSTrre.Delete(40);
            BSTrre.InOrderTraversalBST(BSTrre.Root);
            Console.WriteLine();
            

            Console.WriteLine(BSTrre.Contains(40) ?"Found" : "Not Found");

            Console.ReadKey();
        }
    }
}
