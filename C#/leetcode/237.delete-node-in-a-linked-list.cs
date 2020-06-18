using System.Reflection.Metadata.Ecma335;
/*
 * @lc app=leetcode id=237 lang=csharp
 *
 * [237] Delete Node in a Linked List
 */
namespace DeleteNode
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
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
            // if()
        }
    }
    // @lc code=end

}