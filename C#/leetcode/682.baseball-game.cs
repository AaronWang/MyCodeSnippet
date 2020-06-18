/*
 * @lc app=leetcode id=682 lang=csharp
 *
 * [682] Baseball Game
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CalPoints
{
    // @lc code=start
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "C":
                        stack.Pop();
                        break;
                    case "D":
                        stack.Push((int)stack.Peek() * 2);
                        break;
                    case "+":
                        int previous = (int)stack.Pop();
                        int newScore = previous + (int)stack.Peek();
                        stack.Push(previous);
                        stack.Push(newScore);
                        break;
                    default:
                        stack.Push(Convert.ToInt16(ops[i]));
                        break;
                }
            }
            return stack.ToArray<int>().Sum();
        }
    }
    // @lc code=end
}