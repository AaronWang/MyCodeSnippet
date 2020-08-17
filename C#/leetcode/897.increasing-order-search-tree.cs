/*
 * @lc app=leetcode id=897 lang=csharp
 *
 * [897] Increasing Order Search Tree
 */
namespace InscreasingBST
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
        public TreeNode IncreasingBST(TreeNode root)
        {
            return root;
        }
    }
    // @lc code=end

}