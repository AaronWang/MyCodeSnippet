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
            if (s == null) return false;
            else return SameTree(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
        public bool SameTree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s != null && t != null && s.val == t.val && SameTree(s.left, t.left) && SameTree(s.right, t.right))
                return true;
            else return false;
        }
    }
    // @lc code=end

}