using System;
using System.Linq;
/*
 * @lc app=leetcode id=1356 lang=csharp
 *
 * [1356] Sort Integers by The Number of 1 Bits
 */
namespace SortByBits
{
    // @lc code=start
    public class Solution
    {
        public int[] SortByBits(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int biti;
                    int bitj;
                    biti = CountBinaryBit(arr[i]);
                    bitj = CountBinaryBit(arr[j]);
                    if (biti > bitj)
                    {
                        arr[i] += arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                        continue;
                    }
                    if (biti == bitj && arr[i] > arr[j])
                    {
                        arr[i] += arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }
            return arr;
        }
        public int CountBinaryBit(int i)
        {
            int count = 0;
            while (i > 0)
            {
                count += i & 1;
                i = i >> 1;
            }
            return count;
            // return Convert.ToString(i,2).Where(c => c == '1').Count();
        }
    }
    // @lc code=end

}