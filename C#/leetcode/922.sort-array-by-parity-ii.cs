/*
 * @lc app=leetcode id=922 lang=csharp
 *
 * [922] Sort Array By Parity II
 */
namespace sortarraybyparityII{
// @lc code=start
public class Solution
{
    public int[] SortArrayByParityII(int[] A)
    {
        int[] B = new int[A.Length];
        int even = 0, odd = 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                B[even] = A[i];
                even += 2;
            }
            else
            {
                B[odd] = A[i];
                odd += 2;
            }
        }
        return B;
    }
}
// @lc code=end

}