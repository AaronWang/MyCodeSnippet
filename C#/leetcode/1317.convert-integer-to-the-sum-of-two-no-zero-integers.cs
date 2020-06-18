/*
 * @lc app=leetcode id=1317 lang=csharp
 *
 * [1317] Convert Integer to the Sum of Two No-Zero Integers
 */
namespace GetNoZeroIntegers
{
    // @lc code=start
    public class Solution
    {
        public int[] GetNoZeroIntegers(int n)
        {
            //brute force
            for (int i = 1; i < n; i++)
            {
                if (!i.ToString().Contains('0') && !(n - i).ToString().Contains('0'))
                    return new int[] { i, n - i };
            }
            return null;
        }
    }
    // @lc code=end

}