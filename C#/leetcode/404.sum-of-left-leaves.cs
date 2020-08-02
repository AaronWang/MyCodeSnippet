using System.ComponentModel.Design.Serialization;
/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
 */
namespace SumOfLeftLeaves
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
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left != null && root.left.right == null && root.left.left == null) return root.left.val + SumOfLeftLeaves(root.right);
            return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        }
    }
    // @lc code=end

}