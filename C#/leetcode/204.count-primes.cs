using System;
using System.Linq;
/*
* @lc app=leetcode id=204 lang=csharp
*
* [204] Count Primes
*/
namespace CountPrimes
{
    // @lc code=start
    public class Solution
    {
        public int CountPrimes(int n)
        {
            // if (n <= 2) return 0;
            int count = 0;
            bool[] array = new bool[n + 1];
            int j = 0;
            int multipleJ = 0;
            Array.Fill(array, true);
            for (int i = 2; i < n; i++)
            {
                if (array[i] == true)
                {
                    count++;
                    j = 1;
                    multipleJ = i;
                    while (multipleJ <= n)
                    {
                        array[multipleJ] = false;
                        j++;
                        multipleJ = j * i;
                    }
                }
            }
            return count;
        }
    }
    // @lc code=end

}