using System.Linq;
using System;
using System.Runtime.CompilerServices;
/*
 * @lc app=leetcode id=1192 lang=csharp
 *
 * [1192] Critical Connections in a Network
 */
using System.Collections.Generic;
namespace CriticalConnection
{   // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     IList<IList<int>> lists = new List<IList<int>>();
        //     IList<int> t = new List<int>();
        //     t.Add(0); t.Add(1);
        //     lists.Add(t);
        //     t = new List<int>();
        //     t.Add(1); t.Add(2);
        //     lists.Add(t);
        //     t = new List<int>();
        //     t.Add(0); t.Add(2);
        //     lists.Add(t);
        //     t = new List<int>();
        //     t.Add(1); t.Add(3);
        //     lists.Add(t);
        //     CriticalConnections(4, lists);
        // }
        public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            IList<IList<int>> lists = new List<IList<int>>();
            Dictionary<int, HashSet<int>> nodesConnections = new Dictionary<int, HashSet<int>>();
            Stack<int> stack = new Stack<int>();
            HashSet<int> tmp;
            bool[] check = new bool[connections.Count];
            for (int i = 0; i < connections.Count; i++)
            {
                if (nodesConnections.ContainsKey(connections[i][0]))
                    nodesConnections[connections[i][0]].Add(connections[i][1]);
                else
                {
                    tmp = new HashSet<int>();
                    tmp.Add(connections[i][1]);
                    nodesConnections.Add(connections[i][0], tmp);
                }
                if (nodesConnections.ContainsKey(connections[i][1]))
                    nodesConnections[connections[i][1]].Add(connections[i][0]);
                else
                {
                    tmp = new HashSet<int>();
                    tmp.Add(connections[i][0]);
                    nodesConnections.Add(connections[i][1], tmp);
                }
            }

            for (int i = 0; i < connections.Count; i++)
            {
                //prepare traveral
                Array.Fill(check, false);
                check[connections[i][0]] = true;
                nodesConnections[connections[i][0]].Remove(connections[i][1]);
                nodesConnections[connections[i][1]].Remove(connections[i][0]);

                stack.Clear();
                stack.Push(connections[i][0]);
                while (stack.Count > 0)
                {
                    int currentNode = stack.Pop();
                    foreach (var item in nodesConnections[currentNode])
                    {
                        if (check[item] == true) continue;
                        check[item] = true;
                        stack.Push(item);
                        if (item == connections[i][1])
                        {
                            stack.Clear();
                            break;
                        }
                    }
                }
                if (check[connections[i][1]] == false)
                {
                    IList<int> foundConnection = new List<int>();
                    foundConnection.Add(connections[i][0]);
                    foundConnection.Add(connections[i][1]);
                    lists.Add(foundConnection);
                }
                nodesConnections[connections[i][0]].Add(connections[i][1]);
                nodesConnections[connections[i][1]].Add(connections[i][0]);
            }
            return lists;
        }
    }
    // @lc code=end
}
