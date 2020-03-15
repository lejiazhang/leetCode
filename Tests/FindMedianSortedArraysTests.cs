using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class FindMedianSortedArraysTests
    {
        [Test]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 12, 13, 14 }, new int[] { 2, 4, 6, 8, 10 }, 7.5)]
        [TestCase(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        public void should_find_median_in_two_sorted_arrays(int[] nums1, int[] nums2, double expected)
        {
            // Act
            var actual = Solution.FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
