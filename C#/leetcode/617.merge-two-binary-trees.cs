/*
 * @lc app=leetcode id=617 lang=csharp
 *
 * [617] Merge Two Binary Trees
 */
namespace MergeTrees
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
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;
            else if (t1 != null && t2 != null)
            {
                t1.val = t1.val + t2.val;
                t1.left = MergeTrees(t1.left, t2.left);
                t1.right = MergeTrees(t1.right, t2.right);
                return t1;
            }
            else return t1 == null ? t2 : t1;
        }
    }
    // @lc code=end
}