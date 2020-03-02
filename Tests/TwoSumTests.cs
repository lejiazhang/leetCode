using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class TwoSumTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 2,7,11,15}, 9, new int[] { 0,1})]
        public void should_pass_violence_cracking(int[] nums, int target, int [] expected)
        {
            // Act
            var actual = TwoSum.twoSum(nums, target);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void should_pass_single_loop_with_dictionary(int[] nums, int target, int[] expected)
        {
            // Act
            var result = TwoSum.TwoSumDic(nums, target);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}