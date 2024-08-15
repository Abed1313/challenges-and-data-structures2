using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.MirrorTree;

namespace TreeImplementationTest
{
    public class MirrorTreeTest
    {
        [Fact]
        public void Test_MirroringTree_InorderTraversal()
        {
            // Arrange
            var tree = new MirrorTree(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);

            // Act
            
            var inOrderResult = tree.InOrderTraversal2(tree.Root);

            // Assert
            var expectedInOrder = new List<int> { 8, 7, 6, 5, 4, 3, 2 }; // This is the mirrored in-order traversal
            Assert.Equal(expectedInOrder, inOrderResult);
        }

        [Fact]
        public void TestSingleNodeTree()
        {
            // Arrange
            var tree = new MirrorTree(10);

            // Act
            var inOrderResult = tree.InOrderTraversal2(tree.Root);

            // Assert
            var expectedInOrder = new List<int> { 10 };
            Assert.Equal(expectedInOrder, inOrderResult);
        }
    }
}
