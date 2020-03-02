using System;
using System.Collections.Generic;

namespace Solutions
{
    public static class TwoSum
    {
        /// <summary>
        /// Time complexity: O(n 2)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] twoSum(int[] nums, int target)
        {
            int[] a = new int[2];

            if (nums == null || nums.Length <= 1)
            {
                return a;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        a[0] = i;
                        a[1] = j;
                    }
                }
            }

            return a;
        }

        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumDic(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            if (nums == null || nums.Length <= 1)
            {
                return new int[2];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                var index = 0;

                if (numsDictionary.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }

                if (numsDictionary.ContainsKey(nums[i]) == false)
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return null;
        }

    }
}
