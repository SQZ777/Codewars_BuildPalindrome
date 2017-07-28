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
            var kata = new Kata();
            var input = "abc";
            var actual = kata.BuildPalindrome(input);
            var expected = "abcba";
            Assert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public string BuildPalindrome(string input)
        {
            var result = input;
            var inputCharArray = input.ToCharArray();
            Array.Reverse(inputCharArray);
            var halfStrgin = new string(inputCharArray).Substring(1, input.Length / 2 +1);
            return result + halfStrgin;
        }
    }
}
