/*
 * @lc app=leetcode id=572 lang=csharp
 *
 * [572] Subtree of Another Tree
 */
namespace IsSubtree
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    // @lc code=start
    public class Solution
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            return true;
        }
    }
    // @lc code=end

}