/*
 * @lc app=leetcode id=832 lang=csharp
 *
 * [832] Flipping an Image
 */

// @lc code=start
public class Solution
{
    public int[][] FlipAndInvertImage(int[][] A)
    {
        int swap;
        for (int j = 0; j < A.Length; j++)
        {
            for (int i = 0; i < A.Length/2; i++)
            {
                swap =A[j][i];
                A[j][i] = A[j][A.Length - i-1] == 0 ? 1 : 0;
                A[j][A.Length-i-1] = swap == 0 ? 1 : 0;
            }
            if (A.Length % 2 == 1)
                A[j][A.Length/2] = A[j][A.Length/2] == 0 ? 1 : 0;
        }
        return A;
        // int[][] B = new int[A.Length][];
        // for (int j = 0; j < A.Length; j++)
        // {
        //     B[j] = new int[A.Length];
        //     for (int i = 0; i < A.Length; i++)
        //     {
        //         B[j][i] = A[j][A.Length - i-1] == 0 ? 1 : 0;
        //     }
        //     // if (A.Length % 2 == 1)
        //     //     B[j][A.Length/2] = A[j][A.Length/2] == 0 ? 1 : 0;
        // }
        // return B;
    }
}
// @lc code=end

