/*
 * @lc app=leetcode id=812 lang=csharp
 *
 * [812] Largest Triangle Area
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestTriangleArea
{
    // @lc code=start
    public class Solution
    {
        public double LargestTriangleArea(int[][] points)
        {
            double max = 0;
            for (int i = 0; i < points.Length - 2; i++)
                for (int j = i + 1; j < points.Length - 1; j++)
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        //S=(1/2)*abs(x1y2+x2y3+x3y1-x1y3-x2y1-x3y2)
                        double cur = 0.5 * Math.Abs(points[i][0] * points[j][1] + points[j][0] * points[k][1] +
                                            points[k][0] * points[i][1] - points[i][0] * points[k][1] -
                                            points[j][0] * points[i][1] - points[k][0] * points[j][1]);
                        if (cur > max)
                            max = cur;
                    }
            return max;

            int[] list = new int[points.Length];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;
            }
            var combi = GetCombination(list, 3);

            return 0.0;
        }
        public IEnumerable<IEnumerable<T>> GetCombination<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombination(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
    // @lc code=end

}