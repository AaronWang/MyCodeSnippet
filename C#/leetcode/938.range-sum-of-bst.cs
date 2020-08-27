/*
 * @lc app=leetcode id=938 lang=csharp
 *
 * [938] Range Sum of BST
 */
namespace RangeSumBST
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
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null) return sum;
            if (root.val >= L && root.val <= R) sum += root.val;
            RangeSumBST(root.left, L, R);
            RangeSumBST(root.right, L, R);
            return sum;
        }
    }
    // @lc code=end

}