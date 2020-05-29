using System;
using System.Collections.Generic;
using System.Linq;
/*
* @lc app=leetcode id=1200 lang=csharp
*
* [1200] Minimum Absolute Difference
*/
namespace MinimumAbsDifference
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     MinimumAbsDifference(new int[] { 3, 2, 4, 5 });
        // }
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> list = new List<IList<int>>();
            List<int> subList = new List<int>();
            int min = int.MaxValue;
            int abs = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                abs = arr[i + 1] - arr[i];
                if (abs > min)
                    continue;
                if (abs < min)
                {
                    min = abs;
                    list.Clear();
                }
                subList = new List<int>();
                subList.Add(arr[i]);
                subList.Add(arr[i + 1]);
                list.Add(subList);
            }
            return list;
            // for (int i = 0; i < arr.Length - 1; i++)
            //     for (int j = i + 1; j < arr.Length; j++)
            //     {
            //         abs = Math.Abs(arr[i] - arr[j]);
            //         if (abs > min)
            //             continue;
            //         if (abs < min)
            //         {
            //             min = abs;
            //             list.Clear();
            //         }
            //         subList = new List<int>();
            //         if (arr[i] < arr[j])
            //         { subList.Add(arr[i]); subList.Add(arr[j]); }
            //         else
            //         { subList.Add(arr[j]); subList.Add(arr[i]); }
            //         list.Add(subList);
            //     }
            // return list.OrderBy(l => l[0]).ToArray();

            // int min = int.MaxValue;
            // var test = arr.Take(arr.Length - 1).Select((x, i) => arr.Skip(i + 1).Select(y => x > y ? new int[] { y, x } : new int[] { x, y }).ToArray()).SelectMany(i => i).ToArray();
            // int min = test.Select(x=>x[1]-x[0]).Min();
            // return test.Where(x=>x[1]-x[0]<=min).OrderBy(x=>x[0]).ToArray();
        }
    }
    // @lc code=end
}