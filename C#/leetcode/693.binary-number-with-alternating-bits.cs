/*
 * @lc app=leetcode id=693 lang=csharp
 *
 * [693] Binary Number with Alternating Bits
 */
namespace HasAlternationBits
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     HasAlternatingBits(10);
        // }
        public bool HasAlternatingBits(int n)
        {
            bool adjacent = false;
            if ((n & 1) == 1) adjacent = true;
            else adjacent = false;
            n = n >> 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    if (adjacent == true)
                        return false;
                    else
                        adjacent = true;
                }
                else
                {
                    if (adjacent == false)
                        return false;
                    else
                        adjacent = false;
                }
                n = n >> 1;
            }
            return true;
        }
    }
    // @lc code=end

}