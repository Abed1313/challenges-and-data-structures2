using Moq;
using LinkedList;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTest
{
    public class MergeSortedListsTest
    {
        [Fact]
        public void oneListEmptyTest()
        {
            //Arreng
            LinkedListt list1 = new LinkedListt();

            LinkedListt list2 = new LinkedListt();
            list2.InsertFirst(1);
            list2.InsertFirst(2);
            list2.InsertFirst(4);

            //Act
            LinkedListt marg = new LinkedListt();
            marg.MergeSort(list1.Head,list2.Head);

            // Assert
            var result = marg.GetLinkedListData(marg);
            Assert.Equal(new[] { 4,2,1}, result);
        }

        [Fact]
        public void twoListEmptyTest()
        {
            //Arreng
            LinkedListt list1 = new LinkedListt();
            LinkedListt list2 = new LinkedListt();

            //Act
            LinkedListt marg = new LinkedListt();

            //Assert
            var result = marg.GetLinkedListData(marg);
            Assert.Equal(new int[] { }, result);
        }

        [Fact]
        public void mergingLists()
        {
            // Arrange
            LinkedListt list1 = new LinkedListt();
            list1.InsertLast(5);
            list1.InsertLast(10);
            list1.InsertLast(15);

            LinkedListt list2 = new LinkedListt();
            list2.InsertLast(2);
            list2.InsertLast(3);
            list2.InsertLast(20);

            //Act
            LinkedListt marg = new LinkedListt();
            marg.MergeSort(list1.Head, list2.Head);

            // Assert
            var result = marg.GetLinkedListData(marg);
            Assert.Equal(new[] { 2, 3, 5, 10, 15, 20 }, result);
        }
    }
}
