/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */
namespace ReverseList
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
        // public void MainTest(string[] args)
        // {
        //     ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
        //     ReverseList(head);
        // }
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode first = head;
            ListNode second = first.next;
            ListNode third = second.next;
            head.next = null;
            while (third != null)
            {
                second.next = first;
                first = second;
                second = third;
                third = third.next;
            }
            second.next = first;
            return second;
        }
    }
    // @lc code=end

}