using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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
