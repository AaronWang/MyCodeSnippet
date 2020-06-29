using System;
/*
 * @lc app=leetcode id=1175 lang=csharp
 *
 * [1175] Prime Arrangements
 */
using System.Collections.Generic;
using System.Linq;

namespace NumPrimeArrangeement3
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     NumPrimeArrangements(100);
        // }
        public int NumPrimeArrangements(int n)
        {
            bool[] numbers = new bool[n + 1];
            Array.Fill(numbers, true);
            int primeCount = 0;
            int tmp = 0;
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == true)
                {
                    primeCount++;
                    tmp = 1;
                    while (i * tmp < n + 1)
                    {
                        numbers[i * tmp] = false;
                        tmp++;
                    }
                }
            }
            Int64 result = 1;
            for (int i = 1; i <= n - primeCount; i++)
            {
                result *= i;
                result = result % 1000000007;
            }
            for (int u = 1; u <= primeCount; u++)
            {
                result *= u;
                result = result % 1000000007;
            }
            return (int)result;
            // Int64 result = Question(primeCount) * Question(n - primeCount);
            // if (result == 0) return int.MaxValue;
            // else return (int)result % 1000000007;
        }

        public int Question(int n)
        {
            Int64 result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= n - i + 1;
                result = result % 1000000007;
            }
            return (int)result % 1000000007;
        }
        public static int GetPermutationSimple(int total, int pick)
        {
            int[] list = new int[total];
            for (int i = 0; i < total; i++)
            {
                list[i] = i;
            }
            return GetPermutation(list, pick).Count();
        }
        public static IEnumerable<IEnumerable<T>> GetPermutation<T>(IEnumerable<T> list, int length)
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutation(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
    // @lc code=end

}