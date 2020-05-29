using System;
using System.Linq;
/*
 * @lc app=leetcode id=1122 lang=csharp
 *
 * [1122] Relative Sort Array
 */

// @lc code=start
namespace relativesortarray
{
    public class Solution
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];
            int p = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                int count = arr1.Where(x => x == arr2[i]).Count();
                Array.Fill(arr3, arr2[i], p, count);
                p += count;
            }
            int[] arr = arr1.Where(x => !arr2.Any(s => x == s)).OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr3[p] = arr[i];
                p++;
            }
            return arr3;
        }
    }
}
// @lc code=end

