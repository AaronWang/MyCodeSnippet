/*
 * @lc app=leetcode id=190 lang=csharp
 *
 * [190] Reverse Bits
 */
namespace ReverseBits
{
    // @lc code=start
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint ans = 0;
            for (int i = 0; i < 32; i++)
            {
                ans <<= 1;
                if ((n & 1) == 1)
                    ans += 1;
                n >>= 1;
            }
            return ans;
        }
    }
    // @lc code=end

}