using Moq;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveTest()
        {
            //Arreng
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
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
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.INsertFirst(1);
            linkedList.INsertFirst(2);
            linkedList.INsertFirst(3);
            linkedList.INsertFirst(4);
            string Expected = "4321";

            //Act
            var Act = new StringWriter();
            Console.SetOut(Act);
            linkedList.DisplayList();
            string Actual = Act.ToString();

            //Assert
            Assert.Equal(Expected, Actual); 
        }
    }
}