/*
 * @lc app=leetcode id=461 lang=csharp
 *
 * [461] Hamming Distance
 */
namespace HammingDistance
{
    // @lc code=start
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int count = 0;
            while (x > 0 || y > 0)
            {
                if ((x & 1) != (y & 1))
                    count++;
                x = x >> 1;
                y = y >> 1;
            }
            return count;
        }
    }
    // @lc code=end

}