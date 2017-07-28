using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuildPalindrome
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

        private static void BuildPalindromeResult(string expected,string input)
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
            var result = input;
            var chararray = input.ToCharArray();
            Array.Reverse(chararray);
            var temp = new string(chararray);
            result += temp.Substring(1, input.Length - 1);
            return result;
        }
    }
}
