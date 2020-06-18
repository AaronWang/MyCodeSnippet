/*
 * @lc app=leetcode id=160 lang=csharp
 *
 * [160] Intersection of Two Linked Lists
 */
using System.Collections.Generic;

namespace GetIntersectionNode
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    // @lc code=start
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> hs = new HashSet<ListNode>();
            while (headA != null || headB != null)
            {
                if (headB != null && hs.Contains(headB)) return headB;
                else hs.Add(headB);
                if (headA != null && hs.Contains(headA)) return headA;
                else hs.Add(headA);
                if (headB != null) headB = headB.next;
                if (headA != null) headA = headA.next;
            }
            return null;
        }
    }
    // @lc code=end

}