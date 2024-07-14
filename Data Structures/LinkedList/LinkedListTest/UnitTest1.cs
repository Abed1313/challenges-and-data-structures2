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
            linkedList.INsertFirst(1);
            linkedList.INsertFirst(2);
            linkedList.INsertFirst(3);
            linkedList.INsertFirst(4);

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
            linkedListt.INsertFirst(1);
            linkedListt.INsertFirst(2);
            linkedListt.INsertFirst(3);
            linkedListt.INsertFirst(4);
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