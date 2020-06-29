using System.ComponentModel.Design.Serialization;
/*
 * @lc app=leetcode id=173 lang=csharp
 *
 * [173] Binary Search Tree Iterator
 */
using System.Collections.Generic;

namespace BSTIterator
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
    public class BSTIterator
    {
        // ["BSTIterator","hasNext"] \n [[[]],[null]]
        Stack<TreeNode> stack;
        public BSTIterator(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            if (root != null) stack.Push(root);
            else return;
            var tmp = root;
            while (tmp.left != null)
            {
                stack.Push(tmp.left);
                tmp = tmp.left;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            while (stack.Count > 0)
            {
                var tmp = stack.Pop();
                int val = tmp.val;
                if (tmp.right != null)
                {
                    stack.Push(tmp.right);
                    tmp = tmp.right;
                    while (tmp.left != null)
                    {
                        stack.Push(tmp.left);
                        tmp = tmp.left;
                    }
                }
                return val;
            }
            return 0;
        }
        public bool HasNext()
        {
            if (stack.Count > 0) return true;
            return false;
        }
    }

    /**
     * Your BSTIterator object will be instantiated and called as such:
     * BSTIterator obj = new BSTIterator(root);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
    // @lc code=end

}