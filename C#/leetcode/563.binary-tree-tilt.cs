/*
 * @lc app=leetcode id=563 lang=csharp
 *
 * [563] Binary Tree Tilt
 */
using System;

namespace FindTilt
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
        public int FindTilt(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Abs(SumNode(root.left) - SumNode(root.right)) + FindTilt(root.left) + FindTilt(root.right);
        }
        public int SumNode(TreeNode root)
        {
            if (root == null) return 0;
            else return root.val + SumNode(root.left) + SumNode(root.right);
        }
    }
    // @lc code=end

}