//using System;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using NUnit.Framework;
//
//namespace Kata
//{
//    //https://www.codewars.com/kata/56541980fa08ab47a0000040/train/csharp
//    /*
//     * 공장에서는 프린터가 상자에 레이블을 인쇄합니다. 한 종류의 상자의 경우 프린터는 단순함을 위해 문자를 사용하여 색상 이름을 지정해야합니다 a to m.
//
//프린터에서 사용하는 색상은 제어 문자열에 기록됩니다. 예를 들어, 
//"좋은"제어 문자열은 aaabbbbhaijjjm프린터가 3 번 색상을, 4 번 색상을, 1 번 색상을, 그리고 1 번 색상을 사용한다는 것을 의미합니다.
//meaning that the printer used three times color a, four times color b, one time color h then one time color a...
//
//때로는 문제가 있습니다 : 색상 부족, 기술적 오작동 및 "나쁜"제어 문자열이 생성 aaaxbbbbyyhwawiwjjjwwm됩니다
//Sometimes there are problems: lack of colors, technical malfunction and a "bad" control string is produced 
//
//당신은 함수를 작성해야 printer_errorA와 같은 문자열 출력됩니다
//에게 프린터의 오류율을 부여 문자열 누구의 분자 오류의 수와 분모 제어 문자열의 길이 합리적인를 표현합니다. 이 부분을 간단한 표현으로 줄이지 마십시오.
//You have to write a function printer_error which given a string will output the error rate of the printer as a string representing 
//a rational whose numerator is the number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.
//
//문자열의 길이는 1보다 크거나 같고에서 a까지의 문자 만 포함 합니다 
//*/
//
//    [TestFixture]
//    public static class PrinterTests
//    {
//
//        [Test]
//        public static void test1()
//        {
//            Console.WriteLine("Testing PrinterError");
//            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
//            Assert.AreEqual("3/56", Printer.PrinterError(s));
//        }
//    }
//
//    public class Printer
//    {
//        public static string PrinterError(String s)
//        {
//            return null;
//        }
//    }
//
//}