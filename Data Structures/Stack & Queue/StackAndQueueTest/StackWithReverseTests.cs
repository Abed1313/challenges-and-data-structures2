﻿using StackAndQueue.ReverseStackUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueTest
{
    public class StackWithReverseTests
    {
        [Fact]
        public void TestReverseStackWithMultipleElements()
        {
            // Assert
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void TestReverseStackWithOneElement()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            // Act
            stack.ReverseStack();

            // Assert
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestReverseEmptyStack()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();

            // Act
            stack.ReverseStack();

            // Assert
            Assert.True(stack.IsEmpty());
        }
    }
}
