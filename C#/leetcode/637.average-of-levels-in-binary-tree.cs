/*
 * @lc app=leetcode id=637 lang=csharp
 *
 * [637] Average of Levels in Binary Tree
 */
using System.Collections.Generic;

namespace AverageOfLevels
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
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> list = new List<double>();
            return list;
        }

    }
    // @lc code=end

}