using System;
/*
 * @lc app=leetcode id=1385 lang=csharp
 *
 * [1385] Find the Distance Value Between Two Arrays
 */
namespace findthedistancevalue{
// @lc code=start
public class Solution
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        int j = 0, result = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (j = 0; j < arr2.Length; j++)
            {
                if (Math.Abs(arr1[i] - arr2[j]) <= d)
                    break;
            }
            if (j == arr2.Length)
                result++;
        }
        return result;
    }
}
// @lc code=end

}