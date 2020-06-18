using System.Net.NetworkInformation;
/*
 * @lc app=leetcode id=876 lang=csharp
 *
 * [876] Middle of the Linked List
 */
using System.Collections.Generic;
using System.Linq;

namespace MiddleNote
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    // @lc code=start
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            List<ListNode> origin = new List<ListNode>();
            while (head != null)
            {
                origin.Add(head);
                head = head.next;
            }
            // int index = origin.Count() % 2 == 1 ? origin.Count() / 2 + 1 : origin.Count();
            // return origin[index];
            return origin[origin.Count() / 2];
        }
    }
    // @lc code=end

}