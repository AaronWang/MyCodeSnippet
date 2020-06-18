/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */
namespace MergeTwoLists
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode head, move;
            if (l1.val < l2.val) { head = l1; l1 = l1.next; }
            else { head = l2; l2 = l2.next; }
            move = head;
            while (l1 != null || l2 != null)
            {
                if (l1 == null) { move.next = l2; return head; }
                if (l2 == null) { move.next = l1; return head; }
                if (l1.val < l2.val) { move.next = l1; l1 = l1.next; }
                else { move.next = l2; l2 = l2.next; }
                move = move.next;
            }
            return head;
        }
    }
    // @lc code=end

}