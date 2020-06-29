/*
 * @lc app=leetcode id=129 lang=csharp
 *
 * [129] Sum Root to Leaf Numbers
 */
using System;

namespace SumNumbers
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

        // [4,9,0,5,1]
        // 1026
        public void MainTest(string[] args)
        {
            SumNumbers(new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0)));
        }
        public int SumNumbers(TreeNode root)
        {
            return LeafNumber(0, root);
        }
        public int LeafNumber(int beforeLeaf, TreeNode leaf)
        {
            if (leaf == null) return 0;
            if (leaf.left == null && leaf.right == null) return beforeLeaf * 10 + leaf.val;
            else
            {
                int left = 0, right = 0;
                if (leaf.left != null) left = LeafNumber(beforeLeaf * 10 + leaf.val, leaf.left);
                if (leaf.right != null) right = LeafNumber(beforeLeaf * 10 + leaf.val, leaf.right);
                return left + right;
            }
        }
    }
    // @lc code=end

}