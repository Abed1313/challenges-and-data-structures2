using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void PreOrderTraversal_Test()
        {
            // Arrange
            var tree = new BinaryTree(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            var expectedOutput = new List<int> { 50, 30, 20, 40, 70, 60, 80 };
            var resultOutput = new List<int>();

            // Act
            tree.PreOrderTraversal(tree.Root);

            void PreOrderCapture(TNode node)
            {
                if (node == null) return;
                resultOutput.Add(node.Value);
                PreOrderCapture(node.Left);
                PreOrderCapture(node.Right);
            }

            // This version of PreOrderTraversal allows us to capture the output
            PreOrderCapture(tree.Root);

            // Assert
            Assert.Equal(expectedOutput, resultOutput);
        }
        [Fact]
        public void InOrderTraversal_Test()
        {
            // Arrange
            var tree = new BinaryTree(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            var expectedOutput = new List<int> { 20 ,30 ,40 ,50 ,60 ,70 ,80 };
            var resultOutput = new List<int>();

            //Act
            tree.InOrderTraversal(tree.Root);

            void InOrderCapture(TNode node)
            {
                if (node == null) return;

                InOrderCapture(node.Left);
                resultOutput.Add(node.Value);
                InOrderCapture(node.Right);
            }

            // This version of PreOrderTraversal allows us to capture the output
            InOrderCapture(tree.Root);

            // Assert
            Assert.Equal(expectedOutput, resultOutput);
        }

        [Fact]
        public void PostOrderTraversal_Test()
        {
            // Arrange
            var tree = new BinaryTree(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            var expectedOutput = new List<int> { 20 ,40 ,30 ,60 ,80 ,70 ,50 };
            var resultOutput = new List<int>();

            //Act
            tree.PostOrderTraversal(tree.Root);

            void PostOrderTraversal(TNode node)
            {
                if (node == null) return;

                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                resultOutput.Add(node.Value);
            }
            // This version of PreOrderTraversal allows us to capture the output
            PostOrderTraversal(tree.Root);
            // Assert
            Assert.Equal(expectedOutput, resultOutput);
        }
    }
}