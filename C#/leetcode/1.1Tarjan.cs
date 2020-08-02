using System;
using System.Collections.Generic;
using System.Linq;

namespace TarjanAlgorithm
{
    public struct Node
    {
        public Node(int value)
        {
            this.value = value;
        }
        public int value;
    }
    public struct TarjanData
    {
        public int dfn;//time stamp
        public int low;//recursion value
    }
    class Solution
    {
        public void MainTest(string[] args)
        {
            main();
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
            TarjanEdge(4, graph);

        }
        // no direction graph
        // critical conection 割边/桥
        //num: total node numbers
        public void TarjanEdge(int num, Dictionary<Node, HashSet<Node>> graph)
        {
            int[] low = new int[num];
            int[] dfn = new int[num];
            bool[] visited = new bool[num];
            Stack<Node> stack = new Stack<Node>();
            stack.Push(graph.First().Key);
            dfn[0] = 0;
            low[0] = -1;
            while (stack.Count > 0)
            {
                Node currentNode = stack.Peek();
                foreach (var item in graph[currentNode])
                {
                    // dfn[item] =;
                    low[item.value] = low[currentNode.value] + 1;
                }
            }
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
        //no direction graph
        // critical Node 割点
        public void TarjanNode(Node node) { }

        //知乎 leetcode trajan 算法一 代码
        const int SIZE = 100010;
        int[] head = new int[SIZE];
        int[] ver = new int[SIZE * 2];
        int[] Next = new int[SIZE * 2];
        int[] dfn = new int[SIZE];
        int[] low = new int[SIZE];
        int n, m, tot, num;// n means total node numbers, m means total edge number;
        bool[] bridge = new bool[SIZE * 2];
        public void add(int x, int y)
        {
            ver[++tot] = y;
            Next[tot] = head[x];
            head[x] = tot;
        }
        public void main()
        {

            // [[0,1],[1,2],[2,0],[1,3]]
            n = 4;
            m = 4;
            tot = 1;
            // for (int i = 1; i <= m; i++)
            // {
            //     int x, y;
            //     add(x, y);
            //     add(y, x);
            // }
            // add(0, 1); add(1, 0);
            // add(0, 2); add(2, 0);
            // add(0, 3); add(3, 0);
            // add(1, 2); add(2, 1);
            n = 6;
            m = 6;
            add(11, 12); add(12, 11);
            add(11, 14); add(14, 11);
            add(11, 13); add(13, 11);
            add(13, 12); add(12, 13);
            add(15, 12); add(12, 15);
            add(17, 12); add(12, 17);
        }
    }
}