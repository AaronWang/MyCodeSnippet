using System;
/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 */
using System.Collections.Generic;

namespace IsBalanced
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
        // public void MainTest(string[] args)
        // {
        //     TreeNode tree = new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(4)), new TreeNode(3)), new TreeNode(2));
        //     IsBalanced(tree);
        // }
        public bool IsBalanced(TreeNode root)
        {

            // [1,2,2,3,3,3,3,4,4,4,4,4,4,null,null,5,5]
            if (root == null) return true;
            if (Math.Abs(DepthOfTree(root.left) - DepthOfTree(root.right)) <= 1)
            {
                if (IsBalanced(root.left) == false || IsBalanced(root.right) == false)
                    return false;
                else return true;
            }
            else return false;
        }
        public int DepthOfTree(TreeNode root)
        {
            if (root == null) return 0;
            else return 1 + Math.Max(DepthOfTree(root.left), DepthOfTree(root.right));
        }
    }
    // @lc code=end

}