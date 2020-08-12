/*
 * @lc app=leetcode id=437 lang=csharp
 *
 * [437] Path Sum III
 */
namespace PathSum
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
        public void MainTest(string[] args)
        {
            // PathSum(new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, null, new TreeNode(1))), 8);
            // PathSum(new TreeNode(1, new TreeNode(2, null)), 2);
            PathSum(new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4, null, new TreeNode(5, null, null))))), 3);
        }
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int count = 0;
            AddParentNode(root);
            count = CountAllRoute(root, sum);
            return count;
        }
        public void AddParentNode(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null) { root.left.val += root.val; AddParentNode(root.left); }
            if (root.right != null) { root.right.val += root.val; AddParentNode(root.right); }
        }
        public void MinusValue(TreeNode root, int value)
        {
            if (root == null) return;
            root.val -= value;
            if (root.left != null) MinusValue(root.left, value);
            if (root.right != null) MinusValue(root.right, value);
        }
        public int CountValue(TreeNode root, int value)
        {
            int count = 0;
            if (root == null) return 0;
            if (root.val == value) count++;
            if (root.left != null) count += CountValue(root.left, value);
            if (root.right != null) count += CountValue(root.right, value);
            return count;
        }
        public int CountAllRoute(TreeNode root, int value)
        {
            int count = 0;
            if (root != null) count += CountValue(root, value);
            if (root.left != null) { MinusValue(root.left, root.val); count += CountAllRoute(root.left, value); }
            if (root.right != null) { MinusValue(root.right, root.val); count += CountAllRoute(root.right, value); }
            return count;
        }
    }
    // @lc code=end

}