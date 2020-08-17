using System;
/*
 * @lc app=leetcode id=671 lang=csharp
 *
 * [671] Second Minimum Node In a Binary Tree
 */
namespace FindSecondMinimumValue
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
        int secondSmallest = int.MaxValue;
        // [1,1,2,1,1,2,2]
        // [1,1,3,1,1,3,4,3,1,1,1,3,8,4,8,3,3,1,6,2,1]

        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null || root.left == null) return -1;
            if (root.left != null)
            {
                if (root.left.val == root.right.val)
                {
                    FindSecondMinimumValue(root.left);
                    FindSecondMinimumValue(root.right);
                    return -1;
                }
                if (root.left.val > root.right.val)
                {
                    secondSmallest = Math.Min(secondSmallest, root.left.val);
                    if (secondSmallest == root.val)
                        secondSmallest = -1;
                    FindSecondMinimumValue(root.right);
                }
                else
                {
                    secondSmallest = Math.Min(secondSmallest, root.right.val);
                    if (secondSmallest == root.val)
                        secondSmallest = -1;
                    FindSecondMinimumValue(root.left);
                }
            }
            return secondSmallest;
        }
    }
    // @lc code=end

}