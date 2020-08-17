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
        public IList<double> list = new List<double>();
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<TreeNode> roots = new List<TreeNode>();
            roots.Add(root);
            Average(roots);
            return list;
        }
        public void Average(List<TreeNode> roots)
        {
            if (roots.Count == 0) return;
            double total = 0;
            List<TreeNode> subs = new List<TreeNode>();
            foreach (TreeNode node in roots)
            {
                total += node.val;
                if (node.left != null)
                    subs.Add(node.left);
                if (node.right != null)
                    subs.Add(node.right);
            }
            list.Add(total / roots.Count);
            Average(subs);
        }
    }
    // @lc code=end

}