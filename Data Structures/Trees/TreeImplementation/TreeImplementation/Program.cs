using System.Xml.Linq;
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


            BinaryTree Btree = new BinaryTree(10);
            Btree.Root.Left = new TNode(5);
            Btree.Root.Right = new TNode(20);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(15);
            Btree.Root.Right.Right = new TNode(25);

            int secondMax = Btree.FindSecondMax(); // Output: 20
            Console.WriteLine("Second Maximum Value: " + secondMax);


            //LeafSum
            BinaryTree BtreeLeafSum = new BinaryTree(9);
            BtreeLeafSum.Root.Left = new TNode(8);
            BtreeLeafSum.Root.Right = new TNode(12);
            BtreeLeafSum.Root.Left.Left = new TNode(3);
            BtreeLeafSum.Root.Left.Right = new TNode(7);
            BtreeLeafSum.Root.Right.Left = new TNode(17);
            BtreeLeafSum.Root.Right.Right = new TNode(23);
            BtreeLeafSum.Root.Left.Left.Right = new TNode(4);

            int leafSum = BtreeLeafSum.LeafSum(BtreeLeafSum.Root); 
            Console.WriteLine("leafSum Value: " + leafSum);

            Console.WriteLine("\nLargest Level Value");
            BinaryTree Btree14 = new BinaryTree(5);
            Btree14.Root = new TNode(5);
            Btree14.Root.Left = new TNode(13);
            Btree14.Root.Right = new TNode(7);
            Btree14.Root.Left.Left = new TNode(3);
            Btree14.Root.Left.Right = new TNode(7);
            Btree14.Root.Right.Left = new TNode(12);
            Btree14.Root.Right.Right = new TNode(20);
            Btree14.Root.Left.Left.Left = new TNode(1);
            Btree14.Root.Left.Left.Right = new TNode(4);
            Btree14.Root.Right.Left.Right = new TNode(11);

            List<int> largestValues = Btree14.LargestLevelValue();

            Console.WriteLine("Largest values at each level:");
            foreach (var value in largestValues)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
