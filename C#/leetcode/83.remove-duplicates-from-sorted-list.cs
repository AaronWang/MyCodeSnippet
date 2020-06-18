/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
 */
namespace DeleteDuplicatesTest
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode origin = head;
            if (head == null) return head;
            while (head.next != null)
            {
                if (head.val == head.next.val)
                {
                    head.next = head.next.next;
                }
                else head = head.next;
            }
            return origin;
        }
    }
    // @lc code=end

}