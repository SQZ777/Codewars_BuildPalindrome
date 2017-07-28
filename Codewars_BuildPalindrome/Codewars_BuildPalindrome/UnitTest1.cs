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
        public void Input_accbacbcabbcca_Should_Be_acbca()
        {
            BuildPalindromeResult("accbbacbcabbcca", "accbbacb");
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
            var length = input.Length - 1;
            for (int i = 0; i < input.Length / 2; i += 2)
            {
                var temp = input.Substring(input.Length / 2 - i, input.Length / 2 + i);
                if (JudgeLeftRightString(temp) && temp.Length > 1)
                {
                    length = input.Length - 1;
                    length = length - i - 2;
                }
            }
            var result = input;
            var x = result.Substring(0, length).ToCharArray();
            Array.Reverse(x);
            result = string.Concat(result, new string(x));

            return result;
        }

        private static bool JudgeLeftRightString(string input)
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
                return true;
            }
            return false;
        }
    }
}
