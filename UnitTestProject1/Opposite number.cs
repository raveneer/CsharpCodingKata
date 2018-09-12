using System;
using System.Linq;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Kata
{
    //Very simple, given a number, find its opposite.
    //
    //Examples:
    //
    //1: -1
    //14: -14
    //-34: 34
    //But can you do it in 1 line of code and without any conditionals?

    [TestFixture]
    public class MyTest
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(-1, Opposite.Do(1));
            Assert.AreEqual(14, Opposite.Do(-14));
        }
    }

    public class Opposite
    {
        public static int Do(int number)
        {
            return -number;
        }
    }
}