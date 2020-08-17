/*
 * @lc app=leetcode id=589 lang=csharp
 *
 * [589] N-ary Tree Preorder Traversal
 */
using System.Collections.Generic;

namespace Preorder
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
        public IList<int> Preorder(Node root)
        {
            // IList<int> list = new List<int>();
            DFS(root);
            return list;
        }
        public void DFS(Node root)
        {
            if (root != null) list.Add(root.val);
            else return;
            foreach (Node sub in root.children)
            {
                DFS(sub);
            }
        }
    }
    // @lc code=end

}