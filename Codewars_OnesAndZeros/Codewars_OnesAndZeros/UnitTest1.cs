using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_OnesAndZeros
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Input_10_Should_Be_2()
        {
            BinaryArrayToNumberResult(2, new[] { 1, 0 });
        }

        [TestMethod]
        public void Input_1000_Should_Be_8()
        {
            BinaryArrayToNumberResult(8, new[] { 1, 0, 0, 0 });
        }

        [TestMethod]
        public void Input_1001_Should_Be_9()
        {
            BinaryArrayToNumberResult(9, new[] { 1, 0, 0, 1 });
        }
        private static void BinaryArrayToNumberResult(int expected, int[] input)
        {
            var kata = new Kata();
            var actual = kata.BinaryArrayToNumber(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int BinaryArrayToNumber(int[] input)
        {
            var result = 0d;
            Array.Reverse(input);
            for (int time = input.Length - 1; time > 0; time--)
            {
                result += input[time] * Math.Pow(2, time);
            }
            return (int)result;
        }
    }
}
