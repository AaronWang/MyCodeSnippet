using System;
/*
 * @lc app=leetcode id=235 lang=csharp
 *
 * [235] Lowest Common Ancestor of a Binary Search Tree
 */
namespace LowestCommonAncestor
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // @lc code=start

    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode tmp = root;
            int max = Math.Max(q.val, p.val);
            int min = Math.Min(q.val, p.val);
            while (!(tmp.val >= min && tmp.val <= max))
            {
                if (tmp.val > max)
                    tmp = tmp.left;
                else if (tmp.val < min)
                    tmp = tmp.right;
            }
            return tmp;
        }
    }
    // @lc code=end

}