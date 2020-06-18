/*
 * @lc app=leetcode id=896 lang=csharp
 *
 * [896] Monotonic Array
 */
namespace ismonotonic
{
    // @lc code=start
    public class Solution
    {
        public bool IsMonotonic(int[] A)
        {
            bool decrease = true, increase = true;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1]) increase = false;
                if (A[i] < A[i + 1]) decrease = false;
                if (increase == false && decrease == false)
                    return false;
            }
            return true;
        }
    }
    // @lc code=end

}