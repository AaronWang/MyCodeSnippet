/*
 * @lc app=leetcode id=993 lang=csharp
 *
 * [993] Cousins in Binary Tree
 */
namespace IsCousins
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
        public bool IsCousins(TreeNode root, int x, int y)
        {
            return true;
        }
    }
    // @lc code=end

}