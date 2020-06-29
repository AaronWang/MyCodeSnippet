/*
 * @lc app=leetcode id=116 lang=csharp
 *
 * [116] Populating Next Right Pointers in Each Node
 */
using System.Collections.Generic;

namespace Connect
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    // @lc code=start

    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null) return null;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node node;
            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                else
                {
                    node = queue.Peek();
                    foreach (var item in queue)
                    {
                        node.next = item;
                        node = item;
                    }
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
            }
            return root;
        }
    }
    // @lc code=end

}