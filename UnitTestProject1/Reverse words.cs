using NUnit.Framework;
using System;

namespace Kata
{
    public class Test_ReverseWord
    {
        [Test]
        public void Example()
        {
            var charArray = "This".ToCharArray();
            Array.Reverse(charArray);
            Assert.AreEqual(charArray, "sihT");

            Assert.AreEqual("12  12", ReverseWord.ReverseWords("21  21"));
            Assert.AreEqual("sihT", ReverseWord.ReverseWords("This"));
            Assert.AreEqual("sihT si na !elpmaxe", ReverseWord.ReverseWords("This is an example!"));
            Assert.AreEqual("double  spaces", ReverseWord.ReverseWords("elbuod  secaps"));
        }

        //join 으로 여러개의 문자열을 구분기호와 함께 하나의 문자열로 합칠 수 있다.
        [Test]
        public void Test_Join()
        {
            Assert.AreEqual("1_2", string.Join("_", new string[] { "1", "2" }));
            Assert.AreEqual("1_2_apple", string.Join("_", new string[] { "1", "2", "apple" }));
            Assert.AreEqual("1 2 apple", string.Join(" ", new string[] { "1", "2", "apple" }));
            Assert.AreEqual("1 2 apple  ", string.Join(" ", new string[] { "1", "2", "apple", " " }));
            Assert.AreEqual("1   2", string.Join(" ", new string[] { "1", " ", "2" }));
        }
    }

    public class ReverseWord
    {
        //최고의 답안
        /*using System.Linq;
        public static class Kata
        {
            public static string ReverseWords(string str) => string.Join(" ", str.Split().Select(x => string.Concat(x.Reverse())));
        }*/

        public static string ReverseWords(string str)
        {
            string result = "";
            string stringBuffer = "";
            for (var index = 0; index < str.Length; index++)
            {
                var cha = str[index];
                if (cha == ' ')
                {
                    ReverseString(ref result, ref stringBuffer);
                    result += " ";
                }
                else if (str.Length - 1 == index)
                {
                    stringBuffer += cha;
                    ReverseString(ref result, ref stringBuffer);
                }
                else
                {
                    stringBuffer += cha;
                }
            }
            return result;
        }

        private static void ReverseString(ref string result, ref string stringBuffer)
        {
            var charArray = stringBuffer.ToCharArray();
            Array.Reverse(charArray);
            result += new string(charArray);
            stringBuffer = "";
        }
    }
}