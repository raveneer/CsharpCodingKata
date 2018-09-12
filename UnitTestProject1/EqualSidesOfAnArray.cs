using System.Linq;
using NUnit.Framework;

//https://www.codewars.com/kata/5679aa472b8f57fb8c000047/train/csharp
/*
당신은 정수들의 배열을 갖게 될 것입니다. 당신의 임무는 배열을 가져 와서 N의 왼쪽에있는 정수의 합이 N의 오른쪽에있는 정수의 합과 같은 인덱스 N을 찾는 것 -1입니다. 이런 일이 일어나지 않는 인덱스가 없으면 반환하십시오 .

예 :

의 당신은 배열을 부여한다고 가정 해 봅시다 {1,2,3,4,3,2,1}:
귀하의 기능은 인덱스를 반환 3하기 때문에 배열 인덱스의 왼쪽의 합 (의 3 위치에, {1,2,3})와 지수 (오른쪽의 합 {3,2,1}) 모두 동일 6.

다른 것을 보자.
당신은 배열을 주어집니다 {1,100,50,-51,1,1}:
함수는 인덱스를 반환 1하기 때문에 배열의 첫번째 위치, 인덱스의 왼쪽의 합 (에서 {1})와 지수 (오른쪽의 합 {50,-51,1,1}) 모두 동일 1.

마지막 하나 :
배열을받습니다 {20,10,-80,10,10,15,35}
. 인덱스 0에서 왼쪽은 {}
오른쪽 입니다. {10,-80,10,10,15,35}
둘 다 0추가 될 때와 같습니다 . (빈 배열은이 문제에서 0과 같습니다.)
인덱스 0은 왼쪽과 오른쪽이 같은 위치입니다.

참고 : 대부분의 프로그래밍 / 스크립팅 언어에서 배열 색인은 0부터 시작합니다.

입력 :
길이의 정수 배열 0 < arr < 1000. 배열의 숫자는 양수 또는 음수의 정수일 수 있습니다.

출력 : 왼쪽의 변이 오른쪽의 변과 같은
가장 낮은 인덱스 . 이러한 규칙에 맞는 색인을 찾지 못하면 반환하게 됩니다.NNN-1

참고 :
여러 답이있는 배열이있는 경우 가장 낮은 올바른 색인을 반환하십시오.
빈 배열은 0이 문제 와 같이 처리되어야합니다 .
 */

[TestFixture]
public class ValidateWordTest
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
        Assert.AreEqual(1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
        Assert.AreEqual(-1, EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
        Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
    }

    [Test]
    public void Test_GetLeftSum()
    {
        Assert.AreEqual(0, EqualSidesOfAnArray.GetLeftSum(new int[0], 0));
        Assert.AreEqual(0, EqualSidesOfAnArray.GetLeftSum(new int[] { 1, 2, 3 }, 0));
        Assert.AreEqual(1, EqualSidesOfAnArray.GetLeftSum(new int[] { 1, 2, 3 }, 1));
        Assert.AreEqual(3, EqualSidesOfAnArray.GetLeftSum(new int[] { 1, 2, 3 }, 2));
    }

    [Test]
    public void Test_GetRightSum()
    {
        Assert.AreEqual(0, EqualSidesOfAnArray.GetRightSum(new int[0], 0));
        Assert.AreEqual(5, EqualSidesOfAnArray.GetRightSum(new int[] { 1, 2, 3 }, 0));
        Assert.AreEqual(3, EqualSidesOfAnArray.GetRightSum(new int[] { 1, 2, 3 }, 1));
        Assert.AreEqual(0, EqualSidesOfAnArray.GetRightSum(new int[] { 1, 2, 3 }, 2));
    }

    public class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            if (!arr.Any())
            {
                return 0;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (GetLeftSum(arr, i) == GetRightSum(arr, i))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLeftSum(int[] arr, int index)
        {
            if (!arr.Any())
            {
                return 0;
            }

            int result = 0;
            for (int i = 0; i < index; i++)
            {
                result += arr[i];
            }
            return result;
        }

        public static int GetRightSum(int[] arr, int index)
        {
            if (!arr.Any())
            {
                return 0;
            }
            int result = 0;
            for (int i = index + 1; i <= arr.Length - 1; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}