using System.Linq;
/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
 */
using System;

namespace SortedArrayToBST
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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            if (nums.Length == 1) return new TreeNode(nums[0]);
            if (nums.Length % 2 == 1)
                return new TreeNode(nums[nums.Length / 2], SortedArrayToBST(nums.Take(nums.Length / 2).ToArray()), SortedArrayToBST(nums.Skip(nums.Length / 2 + 1).Take(nums.Length - nums.Length / 2 - 1).ToArray()));
            else
                return new TreeNode(nums[nums.Length / 2 - 1], SortedArrayToBST(nums.Take(nums.Length / 2 - 1).ToArray()), SortedArrayToBST(nums.Skip(nums.Length / 2).Take(nums.Length - nums.Length / 2).ToArray()));

        }
    }
    // @lc code=end

}