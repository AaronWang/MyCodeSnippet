/*
 * @lc app=leetcode id=509 lang=csharp
 *
 * [509] Fibonacci Number
 */
using System.Collections.Generic;

namespace Fib
{
    // @lc code=start
    public class Solution
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        public int Fib(int N)
        {

            if (N == 0 || N == 1)
                return N;
            if (!dict.ContainsKey(N - 2))
            {
                dict.Add(N - 2, Fib(N - 2));
            }
            if (!dict.ContainsKey(N - 1))
            {
                dict.Add(N - 1, Fib(N - 1));
            }
            return dict[N - 1] + dict[N - 2];
        }
    }
    // @lc code=end

}