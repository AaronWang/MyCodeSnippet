using System.Linq;
/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
 */
namespace BuildTree
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
        // public void MainTest(string[] args)
        // {
        //     BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
        // }
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0) return null;
            TreeNode root = new TreeNode(preorder[0]);
            if (preorder.Length == 1 && inorder.Length == 1)
                return root;
            int index = 0;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == preorder[0])
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
                root.left = BuildTree(preorder.Skip(1).Take(index).ToArray(), inorder.Take(index).ToArray());
            if (index < inorder.Length - 1)
                root.right = BuildTree(preorder.Skip(1 + index).ToArray(), inorder.Skip(index + 1).ToArray());
            return root;
        }
    }
    // @lc code=end

}