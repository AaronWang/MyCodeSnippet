/*
 * @lc app=leetcode id=700 lang=csharp
 *
 * [700] Search in a Binary Search Tree
 */
namespace SearchBST
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
        int sum = 0;
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            if (root.val > val) return SearchBST(root.left, val);
            if (root.val < val) return SearchBST(root.right, val);
            return root;
        }
    }
    // @lc code=end

}