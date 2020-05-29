using System;
/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */
namespace sortedsquares{
// @lc code=start
public class Solution
{
    public int[] SortedSquares(int[] A)
    {
        for(int i=0;i<A.Length;i++)
            A[i]*=A[i];
        Array.Sort(A);// small to big.  1,2,3,4,5
        //interceptive sort algorithm: Insertion sort, HeapSort, QuickSort
        return A;
    }
}
// @lc code=end

}