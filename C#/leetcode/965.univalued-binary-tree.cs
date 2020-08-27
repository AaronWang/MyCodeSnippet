/*
 * @lc app=leetcode id=965 lang=csharp
 *
 * [965] Univalued Binary Tree
 */
namespace IsUnivalTree
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
        bool result = true;
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return result;
            if (root.left != null)
            {
                result = root.val == root.left.val;
                if (result == true)
                {
                    result = result && IsUnivalTree(root.left);
                    if (result == false) return false;
                }
                else
                    return false;
            }
            if (root.right != null)
            {
                result = root.val == root.right.val;
                if (result == true)
                {
                    result = result && IsUnivalTree(root.right);
                }
                else
                    return false;
            }
            return result;
        }
    }
    // @lc code=end

}