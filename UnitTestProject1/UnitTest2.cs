using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Kata
{
    //https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/train/csharp
    /*
     * 정규식 PIN 코드 유효성 검사
     * ATM 기계는 4 또는 6 자리 PIN 코드를 허용하며 PIN 코드는 정확히 4 자리 또는 정확히 6 자리를 포함 할 수 없습니다.
     * 함수에 유효한 PIN 문자열이 전달되면 true를 반환하고 그렇지 않으면 false를 반환합니다.
     */

    using NUnit.Framework;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, ATM.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, ATM.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, ATM.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, ATM.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, ATM.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, ATM.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, ATM.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, ATM.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, ATM.ValidatePin("00000000"), "Wrong output for \"00000000\"");
            Assert.AreEqual(false, ATM.ValidatePin("-12345"), "Wrong output for \"090909\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, ATM.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, ATM.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, ATM.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, ATM.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, ATM.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, ATM.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, ATM.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, ATM.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, ATM.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
    }
}

public class ATM
{
    public static bool ValidatePin(string pin)
    {
        return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsNumber) ;
    }
}