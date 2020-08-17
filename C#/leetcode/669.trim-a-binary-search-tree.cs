/*
 * @lc app=leetcode id=669 lang=csharp
 *
 * [669] Trim a Binary Search Tree
 */
namespace TrimBST
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
        // [3,0,4,null,2,null,null,1] \n 1 \n 3
        //best solution
        public TreeNode Trim(TreeNode root, int L, int R)
        {
            if (root == null) return null;
            else if (root.val < L)
                root = Trim(root.right, L, R);
            else if (root.val > R)
                root = Trim(root.left, L, R);
            else
            {
                root.left = Trim(root.left, L, R);
                root.right = Trim(root.right, L, R);
            }
            return root;
        }
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            return Trim(root, L, R);
            if (root == null) return null;
            //trim root first;
            if (root.val < L)
            {
                root = root.right;
                return TrimBST(root, L, R);
            }
            if (root.val > R)
            {
                root = root.left;
                return TrimBST(root, L, R);
            }
            //trim left and right sub node
            while (root.left != null && root.left.val < L)
            {
                root.left = root.left.right;
            }
            TrimBST(root.left, L, R);
            while (root.right != null && root.right.val > R)
            {
                root.right = root.right.left;
            }
            TrimBST(root.right, L, R);
            return root;
        }
    }
    // @lc code=end

}