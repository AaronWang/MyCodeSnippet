/*
 * @lc app=leetcode id=1175 lang=csharp
 *
 * [1175] Prime Arrangements
 */
using System.Collections.Generic;
using System.Linq;

namespace NumPrimeArrangeement
{
    // @lc code=start
    public class Solution
    {
        public int NumPrimeArrangements(int n)
        {
            return 0;
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