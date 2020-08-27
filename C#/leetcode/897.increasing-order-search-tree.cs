/*
 * @lc app=leetcode id=897 lang=csharp
 *
 * [897] Increasing Order Search Tree
 */
namespace InscreasingBST
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
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode tmp;
            if (root == null) return null;
            if (root.left != null)
            {
                //put root 5  to under 4's right subnode
                tmp = root.left;
                while (tmp.right != null)
                {
                    tmp = tmp.right;
                }
                tmp.right = root;
                //change root;
                tmp = root.left;
                root.left = null;
                root = tmp;
                root = IncreasingBST(root);
            }
            if (root.right != null)
            {
                root.right = IncreasingBST(root.right);
            }
            return root;
        }
    }
    // @lc code=end

}