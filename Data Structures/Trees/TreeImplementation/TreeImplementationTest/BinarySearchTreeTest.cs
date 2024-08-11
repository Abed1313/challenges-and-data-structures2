using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void AddNode_Test()
        {
            // Arrange
            var bst = new BinarySearchTree(50);

            // Act
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);

            var expectedOutput = new List<int> { 20, 40, 30, 60, 80, 70, 50 };
            var resultOutput = new List<int>();

            bst.PostOrderTraversalBST(bst.Root);

            void PostOrderTraversalBST(TNode node)
            {
                if (node == null) return;

                PostOrderTraversalBST(node.Left);
                PostOrderTraversalBST(node.Right);
                resultOutput.Add(node.Value);
            }
            PostOrderTraversalBST(bst.Root);

            // Assert
            Assert.Equal(expectedOutput, resultOutput);
        }

        [Fact]
        public void SearchNode_Test()
        {
            // Arrange
            var bst = new BinarySearchTree(50);

            // Act
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);

            // Perform search
            bool resultNode = bst.Contains(40);

            Assert.True(resultNode);
        }


        [Fact]
        public void RemoveNode_Test()
        {
            // Arrange
            var bst = new BinarySearchTree(50);

            // Act
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);

            bst.Delete(40);

            var expectedOutput = new List<int> { 20, 30, 50, 60, 70, 80 }; // In-order traversal after deletion
            var resultOutput = new List<int>();

            void InOrderTraversalBST(TNode node)
            {
                if (node == null) return;

                InOrderTraversalBST(node.Left);
                resultOutput.Add(node.Value);
                InOrderTraversalBST(node.Right);
            }

            // Perform in-order traversal to collect the result
            InOrderTraversalBST(bst.Root);

            // Assert
            Assert.Equal(expectedOutput, resultOutput);
        }
    }
}
