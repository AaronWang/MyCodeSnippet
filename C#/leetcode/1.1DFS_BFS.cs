using System;
using System.Collections.Generic;
using System.Linq;

namespace DFS_BFS
{
    public struct Node
    {
        public Node(int value)
        {
            this.value = value;
        }
        public int value;
    }
    class Solution
    {
        public void MainTest(string[] args)
        {
            Dictionary<Node, HashSet<Node>> graph = new Dictionary<Node, HashSet<Node>>();
            HashSet<Node> hs = new HashSet<Node>();
            hs.Add(new Node(2));
            hs.Add(new Node(3));
            hs.Add(new Node(4));
            graph.Add(new Node(1), hs);
            hs = new HashSet<Node>();
            hs.Add(new Node(1));
            hs.Add(new Node(3));
            graph.Add(new Node(2), hs);
            hs = new HashSet<Node>();
            hs.Add(new Node(1));
            hs.Add(new Node(2));
            graph.Add(new Node(3), hs);
            hs = new HashSet<Node>();
            hs.Add(new Node(1));
            graph.Add(new Node(4), hs);
            Dictionary<Node, bool> visited = new Dictionary<Node, bool>();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(graph.First().Key);

            //loop method for traversal graph
            while (stack.Count > 0)
            {
                Node currentNode = stack.Peek();
                if (!visited.ContainsKey(currentNode) || visited[currentNode] == false)
                    Console.WriteLine("visiting :" + currentNode);
                if (visited.ContainsKey(currentNode)) visited[currentNode] = true;
                else visited.Add(currentNode, true);
                foreach (var item in graph[currentNode])
                {
                    if (visited.ContainsKey(item) && visited[item] == true)
                        continue;
                    else
                    {
                        stack.Push(item);
                        break;
                    }
                }
                if (currentNode.value == stack.Peek().value) stack.Pop();
            }
            //recursion method for traversal graph
            // dfs(visited, graph, stack);

        }
        public void dfs(Dictionary<Node, bool> visited, Dictionary<Node, HashSet<Node>> graph, Stack<Node> stack)
        {
            Node currentNode = stack.Pop();
            if (visited.ContainsKey(currentNode)) visited[currentNode] = true;
            else visited.Add(currentNode, true);
            Console.WriteLine("visiting :" + currentNode);
            if (graph[currentNode].Count != 0)
            {
                foreach (var item in graph[currentNode])
                {
                    if (visited.ContainsKey(item) && visited[item]) continue;
                    stack.Push(item);
                    dfs(visited, graph, stack);
                }
            }
            // return currentNode;
        }
    }
}