/*
 * @lc app=leetcode id=559 lang=csharp
 *
 * [559] Maximum Depth of N-ary Tree
 */
using System.Collections.Generic;

namespace MaxDepth
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
        public int MaxDepth(Node root)
        {
            return 0;
        }
    }
    // @lc code=end

}