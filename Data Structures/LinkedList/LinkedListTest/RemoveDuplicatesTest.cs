using LinkedList;
using System;
using Xunit;

namespace LinkedListTest.LinkedList
{
    public class RemoveDuplicatesTest
    {
        [Fact]
        public void RemoveDuplicate_NoDuplicates_ListRemainsUnchanged()
        {
            // Arrange
            var linkedList = new LinkedList();
            linkedList.InsertFirst(4);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(1);

            // Act
            LinkedListRemoveDuplicates.RemoveDuplicate(linkedList);

            // Assert
            var result = GetLinkedListData(linkedList);
            Assert.Equal(new[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void RemoveDuplicate_WithDuplicates_OnlyDuplicatesRemoved()
        {
            // Arrange
            var linkedList = new LinkedList();
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(1);

            // Act
            LinkedListRemoveDuplicates.RemoveDuplicate(linkedList);

            // Assert
            var result = GetLinkedListData(linkedList);
            Assert.Equal(new[] { 1, 3, 2 }, result);
        }

        [Fact]
        public void RemoveDuplicate_AllNodesAreDuplicates_ListReducedToOneNode()
        {
            // Arrange
            var linkedList = new LinkedList();
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(1);

            // Act
            LinkedListRemoveDuplicates.RemoveDuplicate(linkedList);

            // Assert
            var result = GetLinkedListData(linkedList);
            Assert.Equal(new[] { 1 }, result);
        }


    }

}