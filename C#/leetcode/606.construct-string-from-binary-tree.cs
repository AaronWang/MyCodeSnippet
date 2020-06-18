/*
 * @lc app=leetcode id=606 lang=csharp
 *
 * [606] Construct String from Binary Tree
 */
namespace tree2Str
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
        public string Tree2str(TreeNode t)
        {
            if (t == null) return "";
            if (t.left == null && t.right == null)
                return t.val.ToString();
            else if (t.left == null && t.right != null)
            {
                return t.val.ToString() + "()" + "(" + Tree2str(t.right) + ")";
            }
            else if (t.left != null && t.right == null)
                return t.val.ToString() + "(" + Tree2str(t.left) + ")";
            else
                return t.val.ToString() + "(" + Tree2str(t.left) + ")" + "(" + Tree2str(t.right) + ")";
        }
    }
    // @lc code=end

}