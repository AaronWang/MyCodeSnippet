/*
 * @lc app=leetcode id=297 lang=csharp
 *
 * [297] Serialize and Deserialize Binary Tree
 */
namespace Deserialize
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // @lc code=start
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return "";
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            return null;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.deserialize(codec.serialize(root));
    // @lc code=end

}