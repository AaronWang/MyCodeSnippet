/*
 * @lc app=leetcode id=590 lang=csharp
 *
 * [590] N-ary Tree Postorder Traversal
 */
using System.Collections.Generic;

namespace Postorder
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    // @lc code=start

    public class Solution
    {
        public IList<int> list = new List<int>();
        public IList<int> Postorder(Node root)
        {
            BFS(root);
            return list;
        }
        public void BFS(Node root)
        {
            if (root == null) return;
            else
            {
                foreach (Node sub in root.children)
                    BFS(sub);
                list.Add(root.val);
            }
        }
    }
    // @lc code=end

}