/*
 * @lc app=leetcode id=145 lang=csharp
 *
 * [145] Binary Tree Postorder Traversal
 */
using System.Collections.Generic;

namespace PostorderTraversal
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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;
            if (root.right == null && root.left == null)
            {
                list.Add(root.val);
                return list;
            }
            else
            {
                if (root.left != null && root.right != null)
                {
                    list.AddRange(PostorderTraversal(root.left));
                    list.AddRange(PostorderTraversal(root.right));
                }
                else
                {
                    if (root.left != null)
                        list.AddRange(PostorderTraversal(root.left));
                    if (root.right != null)
                        list.AddRange(PostorderTraversal(root.right));
                }
                list.Add(root.val);
            }
            return list;
        }
    }
    // @lc code=end

}