/*
 * @lc app=leetcode id=530 lang=csharp
 *
 * [530] Minimum Absolute Difference in BST
 */
using System;

namespace GetMinimumDifference
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
        public int GetMinimumDifference(TreeNode root)
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