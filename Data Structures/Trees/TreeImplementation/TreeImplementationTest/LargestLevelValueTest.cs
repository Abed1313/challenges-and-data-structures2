using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
   public class LargestLevelValueTest
    {
        [Fact]
        public void largestLevelValue()
        {
            //Arreng
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

            //Act
            List<int> largestValues = Btree14.LargestLevelValue();
            var expectedInOrder = new List<int> { 5, 13, 20, 11 };

            //Assert
            Assert.Equal(expectedInOrder, largestValues);
        }
    }
}
