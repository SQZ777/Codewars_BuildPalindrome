using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_OnesAndZeros
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_0()
        {
            var kata = new Kata();
            var input = new[] { 0 };
            var actual = kata.BinaryArrayToNumber(input);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_1_Should_Be_2()
        {
            var kata = new Kata();
            var input = new[] { 1 };
            var actual = kata.BinaryArrayToNumber(input);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int BinaryArrayToNumber(int[] input)
        {
            var result = input.Sum(x => x * 2);
            return result;
        }
    }
}
