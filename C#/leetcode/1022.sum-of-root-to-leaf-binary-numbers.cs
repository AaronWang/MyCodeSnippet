/*
 * @lc app=leetcode id=1022 lang=csharp
 *
 * [1022] Sum of Root To Leaf Binary Numbers
 */
namespace SumRootToLeaf
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
        int sum = 0;
        public int SumRootToLeaf(TreeNode root)
        {
            if (root == null) return sum;
            if (root.left == null && root.right == null)
                sum += root.val;
            if (root.left != null)
            {
                root.left.val += root.val * 2;
                SumRootToLeaf(root.left);
            }
            if (root.right != null)
            {
                root.right.val += root.val * 2;
                SumRootToLeaf(root.right);
            }
            return sum;
        }
    }
    // @lc code=end

}