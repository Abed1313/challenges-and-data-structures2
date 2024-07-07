using System;
using Xunit;
using Reverse_Words;
using Microsoft.VisualStudio.TestPlatform.TestHost; 

namespace Reverse_Words.Tests
{
    public class ReverseWordsTests
    {
        [Fact]
        public void ReverseWords_ShouldReverseWord()
        {
            // Arrange
            string input = "csharp is programming language";
            string expectedOutput = "language programming is csharp";
            
            // Act 
            string actualOutput = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void ReverseWords_Should()
        {
            // Test case 1
            string input1 = "csharp is programming language";
            string expectedOutput1 = "language programming is csharp";
            Assert.Equal(expectedOutput1, Program.ReverseWords(input1));

            // Test case 2 (New test case)
            string input2 = "Reverse the words in this sentence";
            string expectedOutput2 = "sentence this in words the Reverse";
            Assert.Equal(expectedOutput2, Program.ReverseWords(input2));
        }
    }
}
