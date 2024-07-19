using LinkedList;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTest.LinkedList
{
    public class RemoveDuplicatesTest
    {
        [Fact]
        public void RemoveDuplicate_NoDuplicates_ListRemainsUnchanged()
        {
            // Arrange
            LinkedListt linkedListt = new LinkedListt();
            linkedListt.InsertFirst(4);
            linkedListt.InsertFirst(3);
            linkedListt.InsertFirst(2);
            linkedListt.InsertFirst(1);

            // Act
             LinkedListRemoveDuplicates.RemoveDuplicate(linkedListt);
           

            // Assert
            var result = linkedListt.GetLinkedListData(linkedListt);
            Assert.Equal(new[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void RemoveDuplicate_WithDuplicates_OnlyDuplicatesRemoved()
        {
            // Arrange
            LinkedListt linkedListt = new LinkedListt();
            linkedListt.InsertFirst(3);
            linkedListt.InsertFirst(2);
            linkedListt.InsertFirst(3);
            linkedListt.InsertFirst(1);

            // Act
            LinkedListRemoveDuplicates.RemoveDuplicate(linkedListt);

            // Assert
            var result = linkedListt.GetLinkedListData(linkedListt);
            Assert.Equal(new[] { 1, 3, 2 }, result);
        }

        [Fact]
        public void RemoveDuplicate_AllNodesAreDuplicates_ListReducedToOneNode()
        {
            // Arrange
            LinkedListt linkedListt = new LinkedListt();
            linkedListt.InsertFirst(1);
            linkedListt.InsertFirst(1);
            linkedListt.InsertFirst(1);
            linkedListt.InsertFirst(1);

            // Act
            LinkedListRemoveDuplicates.RemoveDuplicate(linkedListt);

            // Assert
            var result = linkedListt.GetLinkedListData(linkedListt);
            Assert.Equal(new[] { 1 }, result);
        }


    }

}