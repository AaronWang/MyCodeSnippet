/*
 * @lc app=leetcode id=872 lang=csharp
 *
 * [872] Leaf-Similar Trees
 */
using System.Collections.Generic;

namespace LeafSimilar
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
        List<int> r1 = new List<int>();
        List<int> r2 = new List<int>();
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            DFS(root1, r1);
            DFS(root2, r2);
            if (r1.Count == r2.Count)
            {
                for (int i = 0; i < r1.Count; i++)
                {
                    if (r1[i] != r2[i]) return false;
                }
                return true;
            }
            return false;
        }
        public void DFS(TreeNode root, List<int> r)
        {
            if (root == null) return;
            if (root.left == null && root.right == null) r.Add(root.val);
            else
            {
                DFS(root.left, r);
                DFS(root.right, r);
            }
        }
    }
    // @lc code=end

}