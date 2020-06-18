/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 */
namespace IsPowerOfThree
{
    // @lc code=start
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if (n < 1) return false;
            while (n != 1)
            {
                if (n % 3 == 0)
                    n /= 3;
                else return false;
            }
            return true;
        }
    }
    // @lc code=end

}