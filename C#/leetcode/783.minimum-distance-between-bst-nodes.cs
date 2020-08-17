/*
 * @lc app=leetcode id=783 lang=csharp
 *
 * [783] Minimum Distance Between BST Nodes
 */


using System;

namespace MinDiffInBST
{
    //  Definition for a binary tree node.
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
        public int MinDiffInBST(TreeNode root)
        {
            return Recursion(root);
        }

        public int Recursion(TreeNode root)
        {
            TreeNode smaller, bigger;
            int small = int.MaxValue, big = int.MaxValue;
            if (root.left != null)
            {
                smaller = root.left;
                while (smaller.right != null)
                {
                    smaller = smaller.right;
                }
                small = Math.Abs(root.val - smaller.val);
                small = Math.Min(small, Recursion(root.left));
            }
            if (root.right != null)
            {
                bigger = root.right;
                while (bigger.left != null)
                {
                    bigger = bigger.left;
                }
                big = Math.Abs(root.val - bigger.val);
                big = Math.Min(big, Recursion(root.right));
            }
            return Math.Min(big, small);
        }
    }
    // @lc code=end

}