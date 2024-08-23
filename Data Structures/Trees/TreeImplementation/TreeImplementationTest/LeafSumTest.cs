using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;
using TreeImplementation.MirrorTree;

namespace TreeImplementationTest
{
   public class LeafSumTest
    {
        [Fact]
        public void Test_LeafSum()
        {
            // Arrange
            BinaryTree BtreeLeafSum = new BinaryTree(9);
            BtreeLeafSum.Root.Left = new TNode(8);
            BtreeLeafSum.Root.Right = new TNode(12);
            BtreeLeafSum.Root.Left.Left = new TNode(3);
            BtreeLeafSum.Root.Left.Right = new TNode(7);
            BtreeLeafSum.Root.Right.Left = new TNode(17);
            BtreeLeafSum.Root.Right.Right = new TNode(23);
            BtreeLeafSum.Root.Left.Left.Right = new TNode(4);

            //Act
            int leafSum = BtreeLeafSum.LeafSum(BtreeLeafSum.Root);

            //Assert
            Assert.Equal(51, leafSum);
        }
        [Fact]
        public void Test_LeafSum_negative_values()
        {
            // Arrange
            BinaryTree BtreeLeafSum = new BinaryTree(9);
            BtreeLeafSum.Root.Left = new TNode(8);
            BtreeLeafSum.Root.Right = new TNode(12);
            BtreeLeafSum.Root.Left.Left = new TNode(3);
            BtreeLeafSum.Root.Left.Right = new TNode(7);
            BtreeLeafSum.Root.Right.Left = new TNode(-17);
            BtreeLeafSum.Root.Right.Right = new TNode(23);
            BtreeLeafSum.Root.Left.Left.Right = new TNode(-4);

            //Act
            int leafSum = BtreeLeafSum.LeafSum(BtreeLeafSum.Root);

            //Assert
            Assert.Equal(9, leafSum);
        }
    }
}