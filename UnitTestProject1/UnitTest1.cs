using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    yield return new TestCaseData(100l).Returns(5050l);
                    yield return new TestCaseData(300l).Returns(45150l);
                    yield return new TestCaseData(50000l).Returns(1250025000l);
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
                Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
                Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "e", "w", "s", "n", "e", "w", "s", "n", "s" }), "should return true");
                Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
                Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
                Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
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