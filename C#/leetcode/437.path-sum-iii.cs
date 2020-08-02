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
            PathSum(new TreeNode(5, new TreeNode(3, new TreeNode(3), new TreeNode(-2)), new TreeNode(2, null, new TreeNode(1))), 8);
        }
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int count = 0;
            if (root.val - sum == 0) count++;
            if (root.left != null)
            {
                count += PathSum(root.left, sum - root.val);
                count += PathSum(root.left, sum);
            }
            if (root.right != null)
            {
                count += PathSum(root.right, sum - root.val);
                count += PathSum(root.right, sum);
            }

            return count;
        }
    }
    // @lc code=end

}