﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Kata
{
    //https://www.codewars.com/kata/563cf89eb4747c5fb100001b/train/csharp
    /*
     * 믿어지지 않는 무딘 물건의 박물관
믿어지지 않는 무딘 물건의 박물관은 약간의 전람을 제거하고 싶어한다.
인테리어 디자이너 인 미리 암 (Miriam)은 가장 지루한 전시회를 없애기위한 계획을 제시합니다. 그녀는 등급을 부여한 다음 등급이 가장 낮은 등급을 제거합니다.

그러나 그녀가 모든 전시회의 평가를 마친 것처럼 그녀는 중요한 박람회에 참석하기 때문에 가장 낮은 전시회를 제거한
후 항목의 등급을 알려주는 프로그램을 작성하라고합니다. 공정하다.

태스크
주어진 정수 배열을 사용하여 가장 작은 값을 제거하십시오. 원래 배열 / 목록을 변경하지 마십시오.
동일한 값을 갖는 요소가 여러 개인 경우 색인이 더 낮은 요소를 제거하십시오. 빈 배열 / 목록을 얻으면 빈 배열 / 목록을 반환합니다.

왼쪽에있는 요소의 순서는 변경하지 마십시오.

예제들
Remover.RemoveSmallest(new List<int>{1,2,3,4,5}) = new List<int>{2,3,4,5}
Remover.RemoveSmallest(new List<int>{5,3,2,1,4}) = new List<int>{5,3,2,4}
Remover.RemoveSmallest(new List<int>{2,2,1,2,1}) = new List<int>{2,2,2,1}
     */

    [TestFixture]
    public class RemoveSmallestTests
    {
        private static void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, Remover.RemoveSmallest(argument));
        }

        [Test]
        public static void BasicTests()
        {
            Tester(new List<int>(), new List<int>());
            Tester(new List<int> { 1 }, new List<int>());
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
        }
    }

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (!numbers.Any())
            {
                return new List<int>();
            }

            var result = new List<int>(numbers);
            var minimumIndex = result.IndexOf(result.Min());
            result.RemoveAt(minimumIndex);
            return result;
        }
    }
}

namespace GausNeddHelp
{
    //https://www.codewars.com/kata/54df2067ecaa226eca000229/train/csharp
    /*
     * 그의 또 다른 일로 인해 초등 학교의 어린 Gauß 선생님 인 Herr JG Büttner는
     * 지루하고 터무니없는 어린 학생 모금 칼 프리드리히 가우스 (Karl Friedrich Gauss)를
     * 오랜 시간 동안 바쁘게 지내며 동료들에게 산수를 가르치면서 문제를 부여했습니다 1부터 주어진 숫자까지 모든 정수를 더하는 것 n.
     귀하의 임무는 젊은 칼 프리드리히 (Carl Friedrich)가 가능한 빨리이 문제를 해결할 수 있도록 돕는 것입니다. 그래서, 그는 선생님을 놀래주고 레크 리 에이션 간격을 구할 수 있습니다.
     예를 들면 다음과 같습니다.
     f(n=100) // returns 5050
     n이 유효한 양의 정수인지 확인하는 것은 사용자의 의무입니다. 그렇지 않다면 false를 반환하십시오 (Python에서는 None, C에서는 null).
     참고 : 이 kata의 목표는 '기본'수학 공식에 대해 생각하고 코드에서 성능 최적화를 수행하는 방법을 생각해 보는 것입니다.
     고급 - 숙련 된 사용자는 회 돌이없이 한 줄로 해결하거나 최대한 코드를 최적화해야합니다.
     */

    [TestFixture]
    public class RemoveSmallestTests
    {
        [TestFixture]
        public class Sample_Test
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(1).Returns(1);
                    yield return new TestCaseData(2).Returns(3);
                    yield return new TestCaseData(3).Returns(6);
                    yield return new TestCaseData(100L).Returns(5050L);
                    yield return new TestCaseData(300L).Returns(45150L);
                    yield return new TestCaseData(50000L).Returns(1250025000L);
                    yield return new TestCaseData(0).Returns(null);
                }
            }

            [Test, TestCaseSource("testCases")]
            public long? Test(long n) => Kata.RangeSum(n);
        }
    }

    public class Kata
    {
        public static long? RangeSum(long n)
        {
            if (n <= 0)
            {
                return null;
            }

            return (n * (n + 1)) / 2;
        }

        public void Mutate(int number)
        {
            //guard
            if (number > 100) return;

            number++;
        }

        public void Mutate2(int number)
        {
            //guard
            if (number > 100)
            {
                return;
            }

            number++;
        }

        public void Mutate3(int number)
        {
            Debug.Assert(number <= 100);
            number++;
        }
    }
}

namespace TakeTenmin
{
    //https://www.codewars.com/kata/take-a-ten-minute-walk/train/csharp
    /*
     * 당신은 모든 도로가 완벽한 그리드에 배치 된 카디 치아의 도시에 살고 있습니다.
     * 약속 시간에 너무 일찍 도착 했으므로 짧은 산책을 할 수있는 기회를 가지기로 결정했습니다.
     * 도시에서는 시민들에게 휴대 전화로 Walk Generating App을 제공합니다.
     * 버튼을 누를 때마다 걷는 방향을 나타내는 한 글자의 문자열 배열이 전송됩니다
     * (예 : [ 'n', 's', 'w' '이자형']).
     * 당신은 항상 하나의 블록만을 한 방향으로 걸어서 도시 블록 하나를 탐색하는 데 1 분이 걸린다는 것을 알고 있으므로
     * , 앱에서 제공하는 도보로 정확히 10 분이 걸리면 true 를 반환하는 함수를 만듭니다.
     * 일찍 또는 늦게 가고 싶다!) 물론 출발점으로 돌아갈 것입니다. 그렇지 않은 경우는 false를 리턴 합니다.
     참고 : 방향 문자 ( 'n', 's', 'e'또는 'w'만)의 무작위 구색을 포함하는 유효한 배열을 항상 받게됩니다.
     그것은 결코 당신에게 빈 배열을주지 않을 것입니다 (그것은 걷지 않습니다, 그것은 여전히 ​​서 있습니다!).
     */

    [TestFixture]
    public class RemoveSmallestTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual(true, Kata.IsValidWalk(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
                Assert.AreEqual(true, Kata.IsValidWalk(new[] { "n", "e", "w", "s", "n", "e", "w", "s", "n", "s" }), "should return true");
                Assert.AreEqual(false, Kata.IsValidWalk(new[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
                Assert.AreEqual(false, Kata.IsValidWalk(new[] { "w" }), "should return false");
                Assert.AreEqual(false, Kata.IsValidWalk(new[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
            }
        }
    }

    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
            {
                return false;
            }

            int x = 0;
            int y = 0;
            foreach (var s in walk)
            {
                switch (s)
                {
                    case "n":
                        y++;
                        break;

                    case "s":
                        y--;
                        break;

                    case "e":
                        x--;
                        break;

                    case "w":
                        x++;
                        break;

                    default:
                        return false;
                }
            }
            return (x == 0 && y == 0);
        }
    }
}

namespace ReverseLetter
{
    /*Given a string str, reverse it omitting all non-alphabetic characters.
    Example
    For str = "krishan", the output should be "nahsirk".
    For str = "ultr53o?n", the output should be "nortlu".
    Input/Output
    [input] string str
    A string consists of lowercase latin letters, digits and symbols.
    [output] a string*/

    [TestFixture]
    public class myjinxin
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual("ab", kata.ReverseLetter("ba"));
            Assert.AreEqual("ab", kata.ReverseLetter("1ba"));
            Assert.AreEqual("ab", kata.ReverseLetter("b1a"));
            Assert.AreEqual("ab", kata.ReverseLetter("ba1"));
            Assert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));
            Assert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));
            Assert.AreEqual("cba", kata.ReverseLetter("ab23c"));
            Assert.AreEqual("nahsirk", kata.ReverseLetter("krish21an"));
        }
    }

    public class Kata
    {
        public string ReverseLetter(string str)
        {
            var charArray = str.ToCharArray().Reverse().Where(char.IsLetter).ToArray();
            return new string(charArray);
        }
    }
}

namespace CompareStringsbySumofChars
{
    /*
    Compare two strings by comparing the sum of their values (ASCII character code).
    For comparing treat all letters as UpperCase
    null/NULL/Nil/None should be treated as empty strings
    If the string contains other characters than letters, treat the whole string as it would be empty
    Your method should return true, if the strings are equal and false if they are not equal.
    */

    [TestFixture]
    public class ComparingTests
    {
        [Test]
        public void Compare()
        {
            Assert.AreEqual(true, Kata.Compare("AD", "BC"));
            Assert.AreEqual(true, Kata.Compare("AD", "BC"));
            Assert.AreEqual(true, Kata.Compare("gf", "FG"));
            Assert.AreEqual(true, Kata.Compare("zz1", ""));
            Assert.AreEqual(true, Kata.Compare("ZzZz", "ffPFF"));
            Assert.AreEqual(true, Kata.Compare(null, ""));
        }

        [Test]
        public void Test_GetAschiiValue()
        {
            Assert.AreEqual(0, Kata.GetAsciiIntValue(""));
            Assert.AreEqual(0, Kata.GetAsciiIntValue("zz1"));
        }
    }

    public static class Kata
    {
        public static bool Compare(string s1, string s2)
        {
            return GetAsciiIntValue(s1) == GetAsciiIntValue(s2);
        }

        public static int GetAsciiIntValue(string str)
        {
            if (string.IsNullOrEmpty(str) || !str.All(char.IsLetter))
            {
                return 0;
            }
            return Encoding.ASCII.GetBytes(str.ToUpper()).Sum(x => (int)x);
        }
    }
}

namespace HouseOfCats
{
    /*
There are some people and cats in a house.
You are given the number of legs they have all together.
Your task is to return an array containing every possible number of people that could be in the house sorted in ascending order.
It's guaranteed that each person has 2 legs and each cat has 4 legs.

Example
For legs = 6, the output should be [1, 3].
There could be either 1 cat and 1 person (4 + 2 = 6) or 3 people (2 * 3 = 6).
For legs = 2, the output should be [1].
There can be only 1 person.

        Input/Output
[input] integer legs
The total number of legs in the house.
Constraints: 2 ≤ legs ≤ 100.
[output] an integer array
Every possible number of people that can be in the house.
    */

    [TestFixture]
    public class myjinxin
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual(new[] { 1 }, kata.HouseOfCats(2));
            Assert.AreEqual(new[] { 0, 2 }, kata.HouseOfCats(4));
            Assert.AreEqual(new[] { 1, 3 }, kata.HouseOfCats(6));
            Assert.AreEqual(new[] { 0, 2, 4 }, kata.HouseOfCats(8));
            Assert.AreEqual(new[] { 0, 2 }, kata.HouseOfCats(4));
            Assert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 }, kata.HouseOfCats(44));
        }

        [Test]
        public void Test_Enumerable()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, Enumerable.Range(1, 3));
        }
    }

    public class Kata
    {
        public int[] HouseOfCats(int legs)
        {
            var query = from number in Enumerable.Range(0, legs / 2 + 1)
                        where ((legs - number * 2) % 4 == 0)
                        select number;
            return query.ToArray();
        }
    }
}

namespace Isograms
{
    /*
아이소 그램은 반복되는 문자가 없거나 연속적이거나 연속적이지 않은 단어입니다.
문자 만 포함하는 문자열이 isogram인지 여부를 결정하는 함수를 구현합니다.
빈 문자열이 isogram이라고 가정합니다. 대소 문자를 무시하십시오.
    */

    [TestFixture]
    public class BasicTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Kata.IsIsogram(str);

        [Test]
        public void DistinctTest()
        {
            var str = "abacd";
            var result = str.ToCharArray().Distinct();
            Assert.AreEqual(new[] { 'a', 'b', 'c', 'd' }, result.ToArray());
        }
    }

    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            var origianl = str.ToUpper().ToArray();
            var distincted = str.ToUpper().Distinct().ToArray();
            return origianl.Sum(x => char.GetNumericValue(x)) == distincted.Sum(x => char.GetNumericValue(x));
        }
    }
}

namespace TrollsAttack
{
    /*
트롤들이 귀하의 코멘트 섹션을 공격하고 있습니다!
이 상황을 처리하는 일반적인 방법은 트롤의 의견에서 모든 모음을 제거하여 위협을 중화하는 것입니다.
당신의 임무는 문자열을 취하고 모든 모음이 제거 된 새로운 문자열을 반환하는 함수를 작성하는 것입니다.
예를 들어 "This website is LOSERS LOL!"이라는 문자열입니다. "Ths wbst s fr lsrs LL"이 될 것입니다.
주 :이 kata y는 모음으로 간주되지 않습니다.
    */

    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("", Kata.Disemvowel("aeiou"));
            Assert.AreEqual("", Kata.Disemvowel("AEIOU"));
            Assert.AreEqual("", Kata.Disemvowel(""));
            Assert.AreEqual("_b", Kata.Disemvowel("A_b"));
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }
    }

    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            var vowels = "aeiouAEIOU";
            return new string(str.Where(x => !vowels.Contains(x)).ToArray());
        }
    }
}

namespace PascalTriagle
{
    /*
     * Wikipedia article on Pascal's Triangle: http://en.wikipedia.org/wiki/Pascal's_triangle
     Write a function that, given a depth (n), returns a single-dimensional array representing Pascal's Triangle to the n-th level.
    */

    [TestFixture]
    public class PascalsTriangleTests
    {
        [Test]
        public static void Level1()
        {
            Assert.AreEqual(new List<int> { 1 }, Kata.PascalsTriangle(1));
            Assert.AreEqual(new List<int> { 1, 1, 1 }, Kata.PascalsTriangle(2));
            Assert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1 }, Kata.PascalsTriangle(3));
            Assert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, Kata.PascalsTriangle(4));
            Assert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 }, Kata.PascalsTriangle(5));
        }
    }

    //다음엔 재귀를 쓰지 않고 풀어볼 것.
    public static class Kata
    {
        public static List<int> PascalsTriangle(int n)
        {
            var result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                result.AddRange(RecursivePascal(i));
            }
            return result;
        }

        public static List<int> RecursivePascal(int rank)
        {
            if (rank == 1)
            {
                return new List<int> { 1 };
            }
            var prevPascal = RecursivePascal(rank - 1);
            var result = new List<int>();
            for (int index = 0; index < rank; index++)
            {
                if (index == 0 || index == rank - 1)
                {
                    result.Add(1);
                }
                else
                {
                    result.Add(prevPascal[index] + prevPascal[index - 1]);
                }
            }
            return result;
        }
    }
}

namespace ConsecutiveString
{
    /*
    strarr문자열 배열 과 정수 가 주어진다 k.당신의 작업은 배열에서 취한 k 개의 연속 된 문자열 로 구성된 첫 번째 가장 긴 문자열 을 반환하는 것입니다.
    예제 : longest_consec ( ""zone ","abigail ","theta ","form ","libe ","zas ","theta ","abigail "], 2) ->"abigailtheta "
    n은 문자열 배열의 길이이고, if n = 0또는 k > n또는 k <= 0""를 반환합니다.
    */

    [TestFixture]
    public static class LongestConsecutivesTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            testing(LongestConsecutives.LongestConsec(new[] { "a", "bb", "ccc", "d" }, 2), "bbccc");
            testing(LongestConsecutives.LongestConsec(new[] { "a", "bb", "ccc", "d" }, 1), "ccc");
            testing(LongestConsecutives.LongestConsec(new[] { "a", "bb", "ccc", "dddddd" }, 1), "dddddd");
            testing(LongestConsecutives.LongestConsec(new[] { "a", "bb", "ccc", "d" }, 0), "");
            testing(LongestConsecutives.LongestConsec(new[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            testing(LongestConsecutives.LongestConsec(new[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
            testing(LongestConsecutives.LongestConsec(new[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");

            testing(LongestConsecutives.LongestConsec(new[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");

            testing(LongestConsecutives.LongestConsec(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            testing(LongestConsecutives.LongestConsec(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");

            testing(LongestConsecutives.LongestConsec(new[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            testing(LongestConsecutives.LongestConsec(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
        }
    }

    public class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            var result = "";
            for (int i = 0; i <= strarr.Length - k; i++)
            {
                var current = string.Join("", strarr.Skip(i).Take(k));
                if (current.Length > result.Length)
                {
                    result = current;
                }
            }
            return result;
        }
    }
}

namespace Factorial
{
    /*
    strarr문자열 배열 과 정수 가 주어진다 k.당신의 작업은 배열에서 취한 k 개의 연속 된 문자열 로 구성된 첫 번째 가장 긴 문자열 을 반환하는 것입니다.
    예제 : longest_consec ( ""zone ","abigail ","theta ","form ","libe ","zas ","theta ","abigail "], 2) ->"abigailtheta "
    n은 문자열 배열의 길이이고, if n = 0또는 k > n또는 k <= 0""를 반환합니다.
    */

    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialOf0ShouldBe1()
        {
            Assert.AreEqual(1, Kata.Factorial(0));
        }

        [Test]
        public void FactorialOf1ShouldBe1()
        {
            Assert.AreEqual(1, Kata.Factorial(1));
        }

        [Test]
        public void FactorialOf2ShouldBe2()
        {
            Assert.AreEqual(2, Kata.Factorial(2));
        }

        [Test]
        public void FactorialOf3ShouldBe6()
        {
            Assert.AreEqual(6, Kata.Factorial(3));
        }

        [Test]
        public void Test_Odd()
        {
            Assert.AreEqual(1, Kata.OddCount(1));
            Assert.AreEqual(1, Kata.OddCount(2));
            Assert.AreEqual(7, Kata.OddCount(15));
            Assert.AreEqual(7511, Kata.OddCount(15023));
        }

        [TestFixture]
        public class BasicTests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(1).Returns(1)
                        .SetDescription("Arguments: (n: 1)\n      Expected: 1");
                    yield return new TestCaseData(2).Returns(10)
                        .SetDescription("Arguments: (n: 2)\n      Expected: 10");
                    yield return new TestCaseData(3).Returns(11)
                        .SetDescription("Arguments: (n: 3)\n      Expected: 11");
                    yield return new TestCaseData(5).Returns(101)
                        .SetDescription("Arguments: (n: 5)\n      Expected: 101");
                }
            }

            [Test, TestCaseSource("testCases")]
            public int Test(int n) =>
                Kata.ToBinary(n);
        }

        [Test]
        public void CorrectTests()
        {
            Assert.AreEqual("LONDON", Kata.Correct("L0ND0N"));
            Assert.AreEqual("DUBLIN", Kata.Correct("DUBL1N"));
            Assert.AreEqual("SINGAPORE", Kata.Correct("51NGAP0RE"));
            Assert.AreEqual("BUDAPEST", Kata.Correct("BUDAPE5T"));
            Assert.AreEqual("PARIS", Kata.Correct("PAR15"));
        }

        [TestFixture]
        public class FeastTest
        {
            [TestCase("great blue heron", "garlic naan")]
            [TestCase("chickadee", "chocolate cake")]
            public void BasicTestsTrue(string beast, string dish)
            {
                Assert.IsTrue(Kata.Feast(beast, dish));
            }

            [TestCase("brown bear", "bear claw")]
            public void BasicTestsFalse(string beast, string dish)
            {
                Assert.IsFalse(Kata.Feast(beast, dish));
            }
        }

        /*[TestFixture]
        public class SolutionTest
        {
            [Test, Description("It should work for basic tests")]
            public void SampleTest()
            {
                Assert.AreEqual("Hi", Kata.Remove("Hi!", 1));
                Assert.AreEqual("Hi", Kata.Remove("Hi!", 100));
                Assert.AreEqual("Hi!!", Kata.Remove("Hi!!!", 1));
                Assert.AreEqual("Hi", Kata.Remove("Hi!!!", 100));
                Assert.AreEqual("Hi", Kata.Remove("!Hi", 1));
                Assert.AreEqual("Hi!", Kata.Remove("!Hi!", 1));
                Assert.AreEqual("Hi", Kata.Remove("!Hi!", 100));
                Assert.AreEqual("!!Hi !!hi!!! !hi", Kata.Remove("!!!Hi !!hi!!! !hi", 1));
                Assert.AreEqual("Hi !!hi!!! !hi", Kata.Remove("!!!Hi !!hi!!! !hi", 3));
                Assert.AreEqual("Hi hi!!! !hi", Kata.Remove("!!!Hi !!hi!!! !hi", 5));
                Assert.AreEqual("Hi hi hi", Kata.Remove("!!!Hi !!hi!!! !hi", 100));
            }
        }*/

        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual(1, Kata.СenturyFromYear(1));
                Assert.AreEqual(1, Kata.СenturyFromYear(100));
                Assert.AreEqual(18, Kata.СenturyFromYear(1705));
                Assert.AreEqual(19, Kata.СenturyFromYear(1900));
                Assert.AreEqual(17, Kata.СenturyFromYear(1601));
                Assert.AreEqual(20, Kata.СenturyFromYear(2000));
            }
        }

        [TestFixture]
        public class Tests
        {
            private static IEnumerable<TestCaseData> sampleTestCases
            {
                get
                {
                    yield return new TestCaseData(new[] { 0 }).Returns(0);
                    yield return new TestCaseData(new[] { 1 }).Returns(1);
                    yield return new TestCaseData(new[] { 2 }).Returns(4);
                    yield return new TestCaseData(new[] { 1, 2, 2 }).Returns(9);
                    yield return new TestCaseData(new[] { 1, 2 }).Returns(5);
                    yield return new TestCaseData(new[] { 5, 3, 4 }).Returns(50);
                }
            }

            [Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
            public int SampleTest(int[] n) => Kata.SquareSum(n);
        }

        [TestFixture]
        public class Test
        {
            [Test]
            public void Test1()
            {
                StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
                StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
                StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
                StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
                StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
            }
        }

        [TestFixture]
        public class Tests_Light
        {
            [TestCase("green", "yellow")]
            [TestCase("yellow", "red")]
            [TestCase("red", "green")]
            public void BasicTests(string s, string expected)
            {
                Assert.That(Kata.UpdateLight(s), Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class Test_DutyFree
        {
            [Test]
            public void SampleTest()
            {
                Assert.AreEqual(166, Kata.DutyFree(12, 50, 1000));
                Assert.AreEqual(294, Kata.DutyFree(17, 10, 500));
                Assert.AreEqual(357, Kata.DutyFree(24, 35, 3000));
            }
        }
    }

    public static class Kata
    {
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            return (int)(hol / (normPrice * ((float)Discount / 100)));
        }

        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green":
                    return "yellow";

                case "yellow":
                    return "red";

                case "red":
                    return "green";

                default:
                    throw new Exception();
            }
        }

        public static string Remove_char(string s)
        {
            return s.Remove(0, 1).Remove(s.Length - 2, 1);
        }

        public static int SquareSum(int[] n)
        {
            return n.Sum(x => x * x);
        }

        public static int СenturyFromYear(int year)
        {
            return ((year - 1) / 100) + 1;
        }

        /*public static string Remove(string s, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Remove(Array.IndexOf(array, s.Where(x => x == '!').First()));
            }
            return s;
        }*/

        public static bool Feast(string beast, string dish)
        {
            return beast.First() == dish.First() && beast.Last() == dish.Last();
        }

        public static string Correct(string text)
        {
            var chars = text.ToCharArray();
            string result = "";
            foreach (var cha in chars)
            {
                switch (cha)
                {
                    case '5':
                        result += 'S';
                        break;

                    case '1':
                        result += 'I';
                        break;

                    case '0':
                        result += 'O';
                        break;

                    default:
                        result += cha;
                        break;
                }
            }
            return result;
        }

        public static int ToBinary(int n)
        {
            string binary = Convert.ToString(n, 2);
            return int.Parse(binary);
        }

        public static int Factorial(int n)
        {
            if (n > 12 || n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (n == 0)
            {
                return 1;
            }

            return Enumerable.Range(1, n).Aggregate(1, (a, b) => a * b);
        }

        public static ulong OddCount(ulong i)
        {
            if (i == 1)
            {
                return 1;
            }
            return i / 2;
        }
    }
}