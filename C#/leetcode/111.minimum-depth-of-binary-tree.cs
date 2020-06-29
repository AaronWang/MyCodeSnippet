/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
 */
using System;

namespace MinDepth
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
        public int MinDepth(TreeNode root)
        {
            // [1,2]
            // result:2
            if (root == null) return 0;
            else if (root.left == null && root.right == null) return 1;
            else
            {
                if (root.left == null)
                    return 1 + MinDepth(root.right);
                if (root.right == null)
                    return 1 + MinDepth(root.left);

                // if (root.left != null && root.right != null)
                return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
            }
        }
    }
    // @lc code=end

}