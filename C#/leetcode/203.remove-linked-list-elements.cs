/*
 * @lc app=leetcode id=203 lang=csharp
 *
 * [203] Remove Linked List Elements
 */
namespace removeelement2
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;
            //remove start val;
            while (head.val == val)
            {
                head = head.next;
                if (head == null) return head;
            }
            ListNode start = head;
            while (start.next != null)
            {
                if (start.next.val == val)
                    start.next = start.next.next;
                else start = start.next;
            }
            return head;
        }
    }
    // @lc code=end

}