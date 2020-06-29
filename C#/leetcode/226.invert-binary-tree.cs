/*
 * @lc app=leetcode id=226 lang=csharp
 *
 * [226] Invert Binary Tree
 */
namespace InvertTree
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
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode tmp;
            if (root.left == null)
                if (root.right == null)
                {
                    return root;
                }
                else
                {
                    root.left = root.right;
                    root.right = null;
                    InvertTree(root.left);
                }
            else
            {
                if (root.right == null)
                {
                    root.right = root.left;
                    root.left = null;
                    InvertTree(root.right);
                }
                else
                {
                    tmp = root.left;
                    root.left = root.right;
                    root.right = tmp;
                    InvertTree(root.left);
                    InvertTree(root.right);
                }
            }
            return root;
        }
    }
    // @lc code=end

}