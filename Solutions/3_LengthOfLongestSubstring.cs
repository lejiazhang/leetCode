using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public partial class Solution
    {

        /*
        给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

示例 1:

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/longest-substring-without-repeating-characters
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。 
        */

        /// <summary>
        /// LengthOfLongestSubstring
        /// 时间复杂度：O(n)O(n)，索引 jj 将会迭代 nn 次。
        /// 空间复杂度（HashMap）：O(min(m, n))O(min(m, n))，与之前的方法相同。
        /// 空间复杂度（Table）：O(m)O(m)，mm 是字符集的大小。
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0; // Edge case
            }

            int n = s.Length, ans = 0;

            int[] index = new int[128]; // current index of character

            // try to extend the range[i, j]
            for (int j = 0, i =0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }

            return ans;
        }
    }
}
