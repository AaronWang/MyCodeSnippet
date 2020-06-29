/*
 * @lc app=leetcode id=951 lang=csharp
 *
 * [951] Flip Equivalent Binary Trees
 */
namespace FlipEquiv
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
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 != null) return false;
            if (root2 == null && root1 != null) return false;
            if (root2 == null && root1 == null) return true;
            if (root1.val != root2.val) return false;
            if (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right) || FlipEquiv(root1.right, root2.left) && FlipEquiv(root1.left, root2.right))
                return true;
            else return false;
        }
    }
    // @lc code=end
}