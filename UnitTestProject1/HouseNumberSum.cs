using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace HouseNumberSum
{
    /*소년은 학교에서 그의 집까지 먼 길을 걷고있다.산책을 더 재미있게하기 위해
     * 그는 걸어가는 동안 지나가는 집의 수를 합산하기로 결정합니다.
     * 불행히도 모든 집에는 숫자가 적혀 있지 않으며 그 위에 소년은 규칙적으로 거리를 바꾸기 위해 번갈아 가며 번호가 특정 순서로 나타나지 않습니다.
    도보 중 어떤 시점에서 그 소년은 그 위에 숫자가 0적혀 있는 집을 만난다 . 그 집을 보았을 때 그의 총에 바로 숫자를 더하는 것을 멈추게한다.
    주어진 일련의 집들이 소년이 얻을 수있는 금액을 결정합니다. 항상 최소한 하나의 집이 0 개가 있다는 것을 보장합니다.

    예
    들어 inputArray = [5, 1, 2, 3, 0, 1, 5, 0, 2], 출력되어야합니다 11.
    그 대답은 다음과 같이 얻어졌다 5 + 1 + 2 + 3 = 11.

    입출력
    [input] 정수 배열 inputArray

    제약 조건 : 5 ≤ inputArray.length ≤ 50, 0 ≤ inputArray[i] ≤ 10.
    [output] 정수*/

    [TestFixture]
    public class myjinxin
    {
        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual(11, kata.HouseNumbersSum(new int[] { 5, 1, 2, 3, 0, 1, 5, 0, 2 }));
            Assert.AreEqual(13, kata.HouseNumbersSum(new int[] { 4, 2, 1, 6, 0 }));
            Assert.AreEqual(10, kata.HouseNumbersSum(new int[] { 4, 1, 2, 3, 0, 10, 2 }));
            Assert.AreEqual(0, kata.HouseNumbersSum(new int[] { 0, 1, 2, 3, 4, 5 }));
        }
    }

    public class Kata
    {
        public int HouseNumbersSum(int[] inputArray)
        {
            return inputArray.TakeWhile(x => x != 0).Sum();
        }
    }
}