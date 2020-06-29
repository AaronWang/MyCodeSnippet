using System;
using System.Linq;
/*
 * @lc app=leetcode id=944 lang=csharp
 *
 * [944] Delete Columns to Make Sorted
 */
namespace MinDeletionSize
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        // }
        public int MinDeletionSize(string[] A)
        {
            int del = 0;
            //index
            for (int i = 0; i < A[0].Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j][i] > A[j + 1][i])
                    {
                        del++;
                        break;
                    }
                }
            }
            return del;
        }
    }
    // @lc code=end
}