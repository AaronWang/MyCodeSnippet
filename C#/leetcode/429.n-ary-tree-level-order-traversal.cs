/*
 * @lc app=leetcode id=429 lang=csharp
 *
 * [429] N-ary Tree Level Order Traversal
 */
using System.Collections.Generic;

namespace LevelOrder
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
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> lists = new List<IList<int>>();
            return lists;
        }
    }
    // @lc code=end
}