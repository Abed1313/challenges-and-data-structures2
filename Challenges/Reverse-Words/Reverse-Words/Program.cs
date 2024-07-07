using System;

namespace Reverse_Words
{
    internal class Program
    {
        public void Main(string[] args)
        {
            string[] testCases = new string[]
            {
                "csharp is programming language",
                "Reverse the words in this sentence",
                "challenges and data structures"
            };

            foreach (var testCase in testCases)
            {
                string reversed = ReverseWords(testCase);
                Console.WriteLine("Input: " + testCase);
                Console.WriteLine("Output: " + reversed);
                Console.WriteLine();
            }
        }

        public string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
