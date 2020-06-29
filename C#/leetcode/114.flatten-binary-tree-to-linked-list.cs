/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
 */
namespace Flatten
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
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                if (root.right != null)
                    GetMostRightSideLeaf(root.left).right = root.right;
                root.right = root.left;
                root.left = null;
                Flatten(root.right);
            }
            else
            {
                if (root.right != null)
                    Flatten(root.right);
            }
            return;
        }
        public TreeNode GetMostRightSideLeaf(TreeNode tree)
        {
            if (tree == null) return null;
            if (tree.right == null) return tree;
            else return GetMostRightSideLeaf(tree.right);
        }
    }
    // @lc code=end

}