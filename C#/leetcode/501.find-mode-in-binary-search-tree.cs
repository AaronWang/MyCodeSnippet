using System.Linq;
/*
 * @lc app=leetcode id=501 lang=csharp
 *
 * [501] Find Mode in Binary Search Tree
 */
using System.Collections.Generic;

namespace FindMode
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
    public struct CountNode
    {
        public int val;
        public int count;
    }
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     // FindMode(new TreeNode(1, null, new TreeNode(2, new TreeNode(2))));
        //     FindMode(new TreeNode(6,
        //     new TreeNode(2,
        //         new TreeNode(0), new TreeNode(4,
        //             new TreeNode(2), new TreeNode(6))),
        //     new TreeNode(8,
        //         new TreeNode(7), new TreeNode(9))));
        // }
        TreeNode tmp;
        public int[] FindMode(TreeNode root)
        {
            List<int> result = new List<int>();
            var tree = TreeFlatten(root);
            int count = 0;
            int maxCount = 0;
            while (tree != null)
            {
                count++;
                if (!(tree.left != null && tree.left.val == tree.val))
                {
                    if (count > maxCount)
                    {
                        result.Clear();
                        result.Add(tree.val);
                        maxCount = count;
                    }
                    else if (count == maxCount)
                    {
                        result.Add(tree.val);
                    }
                    count = 0;
                }
                tree = tree.left;
            }
            return result.ToArray();

            // [6,2,8,0,4,7,9,null,null,2,6]
            //ans  [6,2]
        }
        public TreeNode TreeFlatten(TreeNode root)
        {
            if (root == null) return null;
            if (root.right != null)
            {
                tmp = root.right;
                while (tmp.left != null)
                    tmp = tmp.left;
                tmp.left = root;
                tmp = root.right;
                root.right = null;
                return TreeFlatten(tmp);
            }
            else
            {
                root.left = TreeFlatten(root.left);
                return root;
            }
        }
    }
    // @lc code=end
}