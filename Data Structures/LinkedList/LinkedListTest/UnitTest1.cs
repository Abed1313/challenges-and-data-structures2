using Moq;
using LinkedList;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveTest()
        {
            //Arreng
            LinkedListt linkedList = new LinkedListt();
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(4);

            //Act
            int Actual = linkedList.GetLength();
            linkedList.DeleteSpecifiedData(2);
            int Expected = linkedList.GetLength(); 

            //Assert
            Assert.Equal(Expected, Actual-1);
        }

        [Fact]
        public void DisplayListFirst()
        {
            //Arreng
            LinkedListt linkedListt = new LinkedListt();
            linkedListt.InsertFirst(1);
            linkedListt.InsertFirst(2);
            linkedListt.InsertFirst(3);
            linkedListt.InsertFirst(4);
            string Expected = "4321";

            //Act
            var Act = new StringWriter();
            Console.SetOut(Act);
            linkedListt.DisplayList();
            string Actual = Act.ToString();

            //Assert
            Assert.Equal(Expected, Actual); 
        }
    }
}