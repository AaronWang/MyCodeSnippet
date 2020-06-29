/*
 * @lc app=leetcode id=257 lang=csharp
 *
 * [257] Binary Tree Paths
 */
using System.Collections.Generic;

namespace BinaryTreePaths
{

    //  Definition for a binary tree node.
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
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();
            if (root == null) return list;
            IList<string> tmp;
            if (root.left == null && root.right == null)
                list.Add(root.val.ToString());
            else
            {
                if (root.left != null)
                {
                    tmp = BinaryTreePaths(root.left);
                    foreach (var item in tmp)
                    {
                        list.Add(root.val + "->" + item);
                    }
                }
                if (root.right != null)
                {
                    tmp = BinaryTreePaths(root.right);
                    foreach (var item in tmp)
                    {
                        list.Add(root.val + "->" + item);
                    }
                }
            }
            return list;
        }
    }
    // @lc code=end

}