/*
 * @lc app=leetcode id=852 lang=csharp
 *
 * [852] Peak Index in a Mountain Array
 */
namespace PeakIndexInMountainArray
{
    // @lc code=start
    public class Solution
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            int left, right, mid;
            left = 1;
            right = A.Length - 2;
            mid = left + (right - left) / 2;
            while (left < right - 1)
            {
                mid = left + (right - left) / 2;
                if (A[mid] > A[mid - 1])
                    left = mid;
                else right = mid;
            }
            if (A[left] > A[left - 1] && A[left] > A[left + 1]) return left;
            if (A[right] > A[right - 1] && A[right] > A[right + 1]) return right;
            return mid;
        }
    }
    // @lc code=end

}