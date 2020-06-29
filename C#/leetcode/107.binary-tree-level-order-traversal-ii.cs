using System.Linq;
/*
 * @lc app=leetcode id=107 lang=csharp
 *
 * [107] Binary Tree Level Order Traversal II
 */
using System.Collections.Generic;

namespace LevelOrderBottom
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> lists = new List<IList<int>>();
            if (root == null) return lists;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            IList<int> list;
            TreeNode node;
            while (queue.Count > 0)
            {
                list = new List<int>();
                foreach (var item in queue)
                {
                    list.Add(item.val);
                }
                lists.Add(list);
                int length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return lists.Reverse().ToList();
        }
    }
    // @lc code=end

}