using System;
/*
 * @lc app=leetcode id=849 lang=csharp
 *
 * [849] Maximize Distance to Closest Person
 */
namespace maxdistToClosest
{
    // @lc code=start
    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            bool countLeftZero = true;
            bool countRightZero = true;
            int leftZero = 0, RightZero = 0;
            int MaxConsecutiveZero = 0;
            int tmp = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0 && countLeftZero)
                    leftZero++;
                else
                    countLeftZero = false;
                if (seats[seats.Length - i - 1] == 0 && countRightZero)
                    RightZero++;
                else
                    countRightZero = false;
                if (seats[i] == 0)
                {
                    tmp++;
                    if (tmp > MaxConsecutiveZero)
                        MaxConsecutiveZero = tmp;
                }
                else tmp = 0;
            }

            return Math.Max(Math.Max(leftZero, RightZero), MaxConsecutiveZero / 2 + MaxConsecutiveZero % 2);
        }
    }
    // @lc code=end

}