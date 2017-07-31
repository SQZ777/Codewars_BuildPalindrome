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
            BinaryArrayToNumberResult(0, new[] { 0 });
        }

        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            BinaryArrayToNumberResult(1, new[] { 1 });
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
            var result = 0;

            for (int time = input.Length - 1 ; time >= 0; time--)
            {
                result += PowerSquare(input[time], time);
            }
            return result;
        }

        private static int PowerSquare(int input, int squareTime)
        {
            return input;
        }
    }
}
