using System;
/*
 * @lc app=leetcode id=989 lang=csharp
 *
 * [989] Add to Array-Form of Integer
 */
using System.Collections.Generic;

namespace addtoarrayform
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);
        //     AddToArrayForm(new int[] { 2, 7, 4 }, 181);//455
        //     AddToArrayForm(new int[] { 0 }, 10000);
        //     AddToArrayForm(new int[] { 2, 1, 5 }, 806);
        // }
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            int tempBit;
            int digit = 0;//K’s most right digit
            List<int> result = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                result.Add(A[A.Length - 1 - i]);
            }
            int firstBit = 0;
            do
            {
                digit = K % 10;
                K /= 10;

                if (result.Count > firstBit)
                    result[firstBit] += digit;
                else result.Add(digit);
                tempBit = firstBit;
                while (result[tempBit] >= 10)
                {
                    result[tempBit] %= 10;
                    tempBit++;
                    if (result.Count > tempBit)
                        result[tempBit] += 1;
                    else result.Add(1);
                };
                firstBit++;
            } while (K != 0);
            result.Reverse();
            return result;
        }
    }
    // @lc code=end

}