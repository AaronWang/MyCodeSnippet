/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */
namespace validmountainArray
{
    // @lc code=start
    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;
            bool goUp = true;
            bool goUpOnce = false;
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == A[i + 1]) return false;
                if (goUp)
                {
                    if (A[i] > A[i + 1])
                        goUp = false;
                    if (A[i] < A[i + 1]) goUpOnce = true;
                }
                else
                    if (A[i] < A[i + 1])
                    return false;
            }
            if (!goUpOnce || goUp) return false;
            return true;
        }
    }
    // @lc code=end

}