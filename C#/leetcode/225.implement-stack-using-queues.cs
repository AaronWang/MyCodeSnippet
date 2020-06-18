using System.Xml.Linq;
/*
 * @lc app=leetcode id=225 lang=csharp
 *
 * [225] Implement Stack using Queues
 */
using System.Collections;
using System.Linq;

namespace myStackNampeSpace
{
    // @lc code=start
    public class MyStack
    {
        Queue queue;
        /** Initialize your data structure here. */
        public MyStack()
        {
            queue = new Queue();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            // queue.ToArray().Last();
            for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return (int)queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return (int)queue.ToArray().Last();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (queue.Count == 0) return true;
            else return false;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
    // @lc code=end

}