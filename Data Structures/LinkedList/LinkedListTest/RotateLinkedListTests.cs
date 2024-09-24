using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateLinkedListZero()
        {
            // Arreng
            LinkedListt linkedList1 = new LinkedListt();
            linkedList1.InsertLast(1);
            linkedList1.InsertLast(2);
            linkedList1.InsertLast(3);
            linkedList1.InsertLast(4);
            linkedList1.InsertLast(5);

            linkedList1.RotateLeft(0);

            // Assert
            var result = linkedList1.GetLinkedListData(linkedList1);
            Assert.Equal(new[] { 1, 2 , 3, 4, 5}, result);

        }

        [Fact]
        public void RotateLinkedListSex()
        {
            // Arreng
            LinkedListt linkedList1 = new LinkedListt();
            linkedList1.InsertLast(1);
            linkedList1.InsertLast(2);
            linkedList1.InsertLast(3);
            linkedList1.InsertLast(4);
            linkedList1.InsertLast(5);

            linkedList1.RotateLeft(6);

            // Assert
            var result = linkedList1.GetLinkedListData(linkedList1);
            Assert.Equal(new[] { 2, 3, 4, 5, 1 }, result);

        }
    }
}
