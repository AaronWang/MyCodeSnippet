/*
 * @lc app=leetcode id=263 lang=csharp
 *
 * [263] Ugly Number
 */
namespace IsUgly
{
    // @lc code=start
    public class Solution
    {
        public bool IsUgly(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;
            bool two, three, five;
            do
            {
                two = false;
                three = false;
                five = false;
                if (num % 5 == 0)
                {
                    five = true;
                    num /= 5;
                }
                if (num % 3 == 0)
                {
                    three = true;
                    num /= 3;
                }
                if (num % 2 == 0)
                {
                    two = true;
                    num /= 2;
                }
                if (two == false && three == false && five == false)
                    return false;
            } while (num > 1);
            return true;
        }
    }
    // @lc code=end

}