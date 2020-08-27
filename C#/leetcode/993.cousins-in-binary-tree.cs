/*
 * @lc app=leetcode id=993 lang=csharp
 *
 * [993] Cousins in Binary Tree
 */
using System.Collections.Generic;

namespace IsCousins
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
        Dictionary<int, TreeNode> dict = new Dictionary<int, TreeNode>();
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null)
                return false;
            if (root.val == x || root.val == y) return false;
            List<TreeNode> list = new List<TreeNode>();
            list.Add(root);
            return IsCousinsRecursion(list, x, y);
        }
        // [1,2,3,null,4] \n2 \n3
        public bool IsCousinsRecursion(List<TreeNode> list, int x, int y)
        {
            bool hasX = false, hasY = false;
            bool previousX = false, previousY = false;
            bool tmp;
            for (int i = 0; i < list.Count; i++)
            {
                previousX = hasX;
                previousY = hasY;
                if (list[i].left != null)
                {
                    if (list[i].left.val == x) hasX = true;
                    else if (list[i].left.val == y) hasY = true;
                }
                if (list[i].right != null)
                {
                    if (list[i].right.val == x) hasX = true;
                    else if (list[i].right.val == y) hasY = true;
                }
                if (!previousX && !previousY && hasX && hasY) return false;
                if (hasX && hasY) return true;
            }
            if (hasX || hasY) return false;
            List<TreeNode> listSub = new List<TreeNode>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].left != null)
                    listSub.Add(list[i].left);
                if (list[i].right != null)
                    listSub.Add(list[i].right);
            }
            return IsCousinsRecursion(listSub, x, y);
        }
    }
    // @lc code=end

}