/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */
namespace IsPowerOfFour
{
    // @lc code=start
    public class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            int countOne = 0;
            int countIndex = 0;
            while (num > 0)
            {
                countIndex++;
                if ((num & 1) == 1)
                    countOne++;
                num = num >> 1;
            }
            if (countOne > 1) return false;
            if (countIndex % 2 == 1) return true;
            else return false;
        }
    }
    // @lc code=end

}