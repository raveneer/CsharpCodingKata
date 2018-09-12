using System;
using System.Linq;
using System.Runtime.CompilerServices;
using NUnit.Framework;

/*너는 동물원에있어...모든 몽구미가 이상하게 보인다.뭔가 잘못되었습니다 - 누군가가 갔다가 그들의 머리와 꼬리를 바꿨습니다!
동물들을 되돌려 저장하십시오.세 개의 값 (꼬리, 몸체, 머리) 을 갖는 배열이 주어질 것입니다.
동물이 올바른 길 (머리, 몸, 꼬리) 이되도록 배열을 다시 배열하는 것은 당신의 직업입니다.
테스트에서 얻을 수있는 다른 모든 배열 /리스트에 대해서도 동일합니다 : 똑같은 논리 - 요소로 요소 위치를 변경해야합니다!*/

namespace Solution
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "head", "body", "tail" }, Kata.FixTheMeerkat(new string[] { "tail", "body", "head" }));
            Assert.AreEqual(new string[] { "heads", "body", "tails" }, Kata.FixTheMeerkat(new string[] { "tails", "body", "heads" }));
            Assert.AreEqual(new string[] { "top", "middle", "bottom" }, Kata.FixTheMeerkat(new string[] { "bottom", "middle", "top" }));
            Assert.AreEqual(new string[] { "upper legs", "torso", "lower legs" }, Kata.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }));
            Assert.AreEqual(new string[] { "ground", "rainbow", "sky" }, Kata.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }));
        }
    }

    public class Kata
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr.Reverse().ToArray();
        }
    }
}