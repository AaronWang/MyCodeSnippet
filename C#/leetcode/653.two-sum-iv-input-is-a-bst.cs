/*
 * @lc app=leetcode id=653 lang=csharp
 *
 * [653] Two Sum IV - Input is a BST
 */
using System.Collections.Generic;

namespace FindTarget
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

        Dictionary<int, int> dt = new Dictionary<int, int>();
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null) return false;
            if (dt.ContainsKey(root.val)) { return FindTarget(root.left, k) || FindTarget(root.right, k); }
            else
            {
                if (dt.ContainsKey(k - root.val)) return true;
                else
                {
                    dt.Add(root.val, root.val);
                    return FindTarget(root.left, k) || FindTarget(root.right, k);
                }
            }
        }
    }
    // @lc code=end
}