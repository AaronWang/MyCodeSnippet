/*
 * @lc app=leetcode id=1038 lang=csharp
 *
 * [1038] Binary Search Tree to Greater Sum Tree
 */
namespace BstToGst
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
        public int sum = 0;
        public TreeNode BstToGst(TreeNode root)
        {

            if (root == null) return root;
            RecursionSolution(root);
            return root;
        }

        public void RecursionSolution(TreeNode root)
        {
            if (root != null)
            {
                RecursionSolution(root.right);
                root.val += sum;
                sum = root.val;
                RecursionSolution(root.left);
            }
        }
    }
    // @lc code=end

}