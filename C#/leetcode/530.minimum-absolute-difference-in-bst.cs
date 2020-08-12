/*
 * @lc app=leetcode id=530 lang=csharp
 *
 * [530] Minimum Absolute Difference in BST
 */
namespace GetMinimumDifference
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
        public int GetMinimumDifference(TreeNode root)
        {
            if(root ==null)return 0;

            return 0;
        }
        public int Recursion(TreeNode root)
        {
            if (root == null) return;
        }

    }
    // @lc code=end

}