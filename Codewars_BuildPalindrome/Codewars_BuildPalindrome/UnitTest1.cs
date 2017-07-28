using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_BuildPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_abc_Should_Be_abcba()
        {
            BuildPalindromeResult("abcba", "abc");
        }

        [TestMethod]
        public void Input_abcd_Should_Be_abcdcba()
        {
            BuildPalindromeResult("abcdcba", "abcd");
        }

        [TestMethod]
        public void Input_ababa_Should_Be_ababa()
        {
            BuildPalindromeResult("ababa", "ababa");
        }

        private static void BuildPalindromeResult(string expected, string input)
        {
            var kata = new Kata();
            var actual = kata.BuildPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string BuildPalindrome(string input)
        {
            var leftString = input.Substring(0, input.Length / 2);
            var rightString = input.Length % 2 == 0
                ? input.Substring(input.Length / 2, input.Length / 2)
                : input.Substring(input.Length / 2 + 1, input.Length / 2);
            var rightCharArray = rightString.ToCharArray();
            Array.Reverse(rightCharArray);
            rightString = new string(rightCharArray);
            if (leftString.Equals(rightString))
            {
                return input;
            }

            var result = input;
            var inputCharArray = input.ToCharArray();
            Array.Reverse(inputCharArray);
            var halfStrgin = new string(inputCharArray).Substring(1, input.Length / 2 + 1);
            return result + halfStrgin;
        }


    }
}
