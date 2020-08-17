/*
 * @lc app=leetcode id=965 lang=csharp
 *
 * [965] Univalued Binary Tree
 */
namespace IsUnivalTree
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
        public bool IsUnivalTree(TreeNode root)
        {
            return true;
        }
    }
    // @lc code=end

}