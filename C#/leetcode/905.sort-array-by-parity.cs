/*
 * @lc app=leetcode id=905 lang=csharp
 *
 * [905] Sort Array By Parity
 */
namespace sortarraybyparity{
// @lc code=start
public class Solution
{
    public int[] SortArrayByParity(int[] A)
    {
        for (int i = 0; i < A.Length - 1; i++)
        {
            if (A[i] % 2 == 1)
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] % 2 == 0)
                    { 
                        A[i]+=A[j];
                        A[j]=A[i]-A[j];
                        A[i]=A[i]-A[j];
                    }
                }
        }
        return A;
    }
}
// @lc code=end

}