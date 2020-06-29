/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
 */
namespace IsSymmetric
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
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;
            if (root.left != null && root.right != null)
                return MirrorTree(root.left, root.right);
            else return false;
        }
        public bool MirrorTree(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;
            if (a != null && b != null)
            {
                if (a.val == b.val)
                    return MirrorTree(a.left, b.right) && MirrorTree(a.right, b.left);
                else return false;
            }
            else return false;
        }
    }
    // @lc code=end

}