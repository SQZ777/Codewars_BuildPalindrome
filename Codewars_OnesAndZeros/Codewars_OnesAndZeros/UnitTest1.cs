using System;
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
            var input = new[] {0};
            var actual = kata.BinaryArrayToNumber(input);
            var expected = 0;
            Assert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public int BinaryArrayToNumber(int[] input)
        {
            return 0;
        }
    }
}
