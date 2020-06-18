/*
 * @lc app=leetcode id=232 lang=csharp
 *
 * [232] Implement Queue using Stacks
 */
using System.Collections;

namespace myQueueNameSpace
{
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     MyQueue my = new MyQueue();
        //     my.Push(1);
        //     my.Push(2);
        //     my.Peek();
        //     my.Pop();
        //     my.Empty();
        // }
    }
    // @lc code=start
    public class MyQueue
    {
        Stack stack = new Stack();
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack = new Stack();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            Stack tmp = new Stack();
            int count = stack.Count;
            for (int i = 0; i < count - 1; i++)
            {
                tmp.Push(stack.Pop());
            }
            int t = (int)stack.Pop();
            count = tmp.Count;
            for (int i = 0; i < count; i++)
            {
                stack.Push(tmp.Pop());
            }
            return t;
        }

        /** Get the front element. */
        public int Peek()
        {
            Stack tmp = new Stack();
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                tmp.Push(stack.Pop());
            }
            int t = (int)tmp.Peek();
            count = tmp.Count;
            for (int i = 0; i < count; i++)
            {
                stack.Push(tmp.Pop());
            }
            return t;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            if (stack.Count == 0) return true;
            else return false;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
    // @lc code=end

}