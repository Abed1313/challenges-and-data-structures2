using TreeImplementation.MirrorTree;

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

            // In Order Traversal
            Console.WriteLine("In Order Traversal");
            BTree.InOrderTraversal(BTree.Root);
            Console.WriteLine("\n----------------------------");

            

            MirrorTree.MirrorTree mirror = new MirrorTree.MirrorTree(10);

            mirror.Insert(5);
            mirror.Insert(18);
            mirror.Insert(3);
            mirror.Insert(7);
            mirror.Insert(15);

            Console.WriteLine("In Order Traversal Mirror Tree");
            //mirror.InOrderTraversal2(mirror.Root);
            List<int> mirroredInorder = mirror.InOrderTraversal2(mirror.Root);
            Console.WriteLine("Mirrored inorder: " + string.Join(", ", mirroredInorder));
            Console.WriteLine("\n----------------------------");

            Console.ReadKey();
        }
    }
}
