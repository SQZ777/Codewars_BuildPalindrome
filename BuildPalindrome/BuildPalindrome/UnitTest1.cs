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
            var kata = new Kata();
            var input = "abc";
            var actual = kata.BuildPalindrome(input);
            var expected = "abcba";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_abcd_Should_Be_abcdcba()
        {
            var kata = new Kata();
            var input = "abcd";
            var actual = kata.BuildPalindrome(input);
            var expected = "abcdcba";
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
