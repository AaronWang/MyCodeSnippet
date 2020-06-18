/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */
namespace HasCycle
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    // @lc code=start
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode jump = head.next;
            while (head != jump)
            {
                if (head == null || jump == null || jump.next == null)
                    return false;
                head = head.next;
                jump = jump.next.next;
            }
            return true;
        }
    }
    // @lc code=end

}