/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */
using System.Collections.Generic;
using System.Linq;

namespace MinStackSpace
{
    // @lc code=start
    public class MinStack
    {
        List<int> list = new List<int>();
        /** initialize your data structure here. */
        public MinStack()
        {
            list = new List<int>();
        }

        public void Push(int x)
        {
            list.Add(x);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int Top()
        {
            return list.Last();
        }

        public int GetMin()
        {
            return list.Min();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
    // @lc code=end

}