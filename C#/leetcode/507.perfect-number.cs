/*
 * @lc app=leetcode id=507 lang=csharp
 *
 * [507] Perfect Number
 */
using System;

namespace CheckPerfectNumber
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     CheckPerfectNumber(28);
        // }
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 1) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    if (i != num / i) sum += num / i;
                }
            }
            return sum == num;
        }
    }
    // @lc code=end

}