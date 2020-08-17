using System.ComponentModel;
/*
 * @lc app=leetcode id=687 lang=csharp
 *
 * [687] Longest Univalue Path
 */
using System;

namespace LongestUnivaluePath
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
        public int LongestUnivaluePath(TreeNode root)
        {
            int longestPath = 0;
            int left = 0, right = 0;
            if (root == null) return 0;
            if (root.left != null)
            {
                left = LongestUnivaluePath(root.left);
                if (root.val == root.left.val) longestPath = 1 + Deepth(root.left);
            }
            if (root.right != null)
            {
                right = LongestUnivaluePath(root.right);
                if (root.val == root.right.val) longestPath += Deepth(root.right) + 1;
            }

            longestPath = Math.Max(longestPath, left);
            return longestPath = Math.Max(longestPath, right);
        }
        // [1,4,5,4,4,5]
        public int Deepth(TreeNode root)
        {
            int left = 0, right = 0;
            if (root == null) return 0;
            if (root.left != null && root.val == root.left.val)
            {
                left = 1 + Deepth(root.left);
            }
            if (root.right != null && root.val == root.right.val)
            {
                right = 1 + Deepth(root.right);
            }
            return Math.Max(left, right);
        }
    }
    // @lc code=end

}