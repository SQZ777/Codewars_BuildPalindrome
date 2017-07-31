using System;
using System.Linq;
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

        [TestMethod]
        public void Input_abababa_Should_Be_ababab()
        {
            BuildPalindromeResult("abababa", "ababab");
        }

        [TestMethod]
        public void Input_accbab_Should_Be_accbabcca()
        {
            BuildPalindromeResult("accbabcca", "accbab");
        }

        [TestMethod]
        public void Input_acbca_Should_Be_acbca()
        {
            BuildPalindromeResult("acbca", "acbca");
        }

        [TestMethod]
        public void Input_accbbacb_Should_Be_accbbacbcabbcca()
        {
            BuildPalindromeResult("accbbacbcabbcca", "accbbacb");
        }
        [TestMethod]
        public void Input_abcdc_Should_Be_abcdcba()
        {
            BuildPalindromeResult("abcdcba", "abcdc");
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
            if (JudgeLeftRightString(input))
                return input;
            for (int i = 1; i < input.Length; i++)
            {
                var partCharArray = input.Substring(0, i).ToCharArray();
                Array.Reverse(partCharArray);
                if (JudgeLeftRightString(string.Concat(input, new string(partCharArray))))
                    return string.Concat(input, new string(partCharArray));
            }
            return input;
        }
        private static bool JudgeLeftRightString(string input)
        {
            var reverseCharArray = input.ToCharArray();
            Array.Reverse(reverseCharArray);
            if (new string(reverseCharArray).Equals(input))
                return true;
            return false;
        }
    }
}
