/*
 * @lc app=leetcode id=933 lang=csharp
 *
 * [933] Number of Recent Calls
 */
using System.Collections.Generic;

namespace ping
{
    // @lc code=start
    public class RecentCounter
    {
        List<int> list = new List<int>();
        public RecentCounter()
        {

        }

        public int Ping(int t)
        {
            // return t - 3000;
            list.Add(t);
            int count = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (t - list[i] <= 3000) count++;
            }
            return count;

        }
    }

    /**
     * Your RecentCounter object will be instantiated and called as such:
     * RecentCounter obj = new RecentCounter();
     * int param_1 = obj.Ping(t);
     */
    // @lc code=end

}