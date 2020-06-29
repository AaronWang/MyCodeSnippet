/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
 */
namespace IsSameTree
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p != null && q != null)
            {
                if (p.val == q.val)
                    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
                else return false;
            }
            else return false;
        }
    }
    // @lc code=end

}