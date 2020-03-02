using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public static string print(ListNode l)
        {
            StringBuilder sb = new StringBuilder();

            while (l != null)
            {
                sb.Append(l.val);

                l = l.next;
            }

            return sb.ToString();
        }
    }


    public partial class Solution
    {

        /*
        2. 两数相加
给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807


        2. Add Two Numbers
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807. 
        */


        /// <summary>
        /// 时间复杂度：O(max(m, n))，假设 mm 和 nn 分别表示 l1l1 和 l2l2 的长度，上面的算法最多重复 max(m, n)次。
        /// 空间复杂度：O(max(m, n))， 新列表的长度最多为 max(m,n) + 1。
        /// https://leetcode-cn.com/problems/add-two-numbers/solution/liang-shu-xiang-jia-by-leetcode/
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;

            int carry = 0;

            while (p != null || q != null || carry != 0)
            {
                int x = p == null ? 0 : p.val;
                int y = q == null ? 0 : q.val;
                int sum = carry + x + y;

                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            return dummyHead.next;
        }
    }
}
