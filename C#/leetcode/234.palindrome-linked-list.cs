/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 */
using System.Collections.Generic;

namespace Ispalindrome2
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
        public bool IsPalindrome(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            ListNode origin = head;
            while (origin != null)
            {
                stack.Push(origin);
                origin = origin.next;
            }
            origin = head;
            while (origin != null)
            {
                if(origin.val!=stack.Pop().val)
                return false;;
                origin = origin.next;
            }

            return true;
        }
    }
    // @lc code=end

}