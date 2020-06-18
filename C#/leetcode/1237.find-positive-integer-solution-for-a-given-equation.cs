/*
 * @lc app=leetcode id=1237 lang=csharp
 *
 * [1237] Find Positive Integer Solution for a Given Equation
 */

/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */
using System.Collections.Generic;

namespace FindSolution
{
    public class CustomFunction
    {
        // Returns f(x, y) for any given positive integers x and y.
        // Note that f(x, y) is increasing with respect to both x and y.
        // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
        // public int f(int x, int y);
    };
    // @lc code=start
    public class Solution
    {
        public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            IList<IList<int>> lists = new List<IList<int>>();
            for (int x = 1; x <= z; x++)
            {
                for (int y = 1; y <= z; y++)
                {
                    if (customfunction.f(x, y) == z)
                    {
                        IList<int> list = new List<int>();
                        list.Add(x);
                        list.Add(y);
                        lists.Add(list);
                        break;
                    }
                }
            }
            return lists;
        }
    }
    // @lc code=end
}