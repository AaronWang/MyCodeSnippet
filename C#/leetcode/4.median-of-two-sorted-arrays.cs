/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */
namespace findmediansortedarrays
{
    // @lc code=start
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        //odd
        int median;
        int value1 = 0, value2 = 0;
        median = (m + n) / 2;
        if (median == 0)
        {
            if (m > 0) return nums1[0];
            if (n > 0) return nums2[0];
            return 0;
        }
        int p1 = 0, p2 = 0;
        for (int i = 0; i < median + 1; i++)
        {
            value2 = value1;
            if (p1 < m && p2 < n)
            {
                if (nums1[p1] > nums2[p2])
                {
                    value1 = nums2[p2];
                    p2++;
                }
                else
                {
                    value1 = nums1[p1];
                    p1++;
                }
            }
            else if (p1 >= m)
            {
                value1 = nums2[p2];
                p2++;
            }
            else if (p2 >= n)
            {
                value1 = nums1[p1];
                p1++;
            }
        }
        if ((m + n) % 2 == 1)
            return value1;
        else
            return (double)(value1 + value2) / 2;
    }
}
    // @lc code=end

}