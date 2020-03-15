using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public partial class Solution
    {
        /*
4. 寻找两个有序数组的中位数
给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。

请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。

你可以假设 nums1 和 nums2 不会同时为空。

示例 1:

nums1 = [1, 3]
nums2 = [2]

则中位数是 2.0
示例 2:

nums1 = [1, 2]
nums2 = [3, 4]

则中位数是 (2 + 3)/2 = 2.5
        */

        /// <summary>
        /// 4.FindMedianSortedArrays
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int sum = nums1.Length + nums2.Length;

            if (sum % 2 == 0)
            {
                return ((double)findKth(nums1, 0, nums2, 0, sum / 2) + (double)findKth(nums1, 0, nums2, 0, sum / 2 + 1)) / 2;
            }

            return findKth(nums1, 0, nums2, 0, (sum + 1) / 2);
        }

        public static int findKth(int[] nums1, int left1, int[] nums2, int left2, int k)
        {
            if (left1 >= nums1.Length) return nums2[left2 + k - 1];
            if (left2 >= nums2.Length) return nums1[left1 + k - 1];
            if (k == 1) return Math.Min(nums1[left1], nums2[left2]);

            int mid1 = left1 + k / 2 - 1 < nums1.Length ? nums1[left1 + k / 2 - 1] : int.MaxValue;
            int mid2 = left2 + k / 2 - 1 < nums2.Length ? nums2[left2 + k / 2 - 1] : int.MaxValue;

            if (mid1 <= mid2)
            {
                return findKth(nums1, left1 + k / 2, nums2, left2, k - k / 2);
            }
            return findKth(nums1, left1, nums2, left2 + k / 2, k - k / 2);
        }
    }
}
