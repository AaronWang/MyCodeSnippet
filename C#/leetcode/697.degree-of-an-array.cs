using System.Linq;
/*
 * @lc app=leetcode id=697 lang=csharp
 *
 * [697] Degree of an Array
 */
using System.Collections.Generic;

namespace FindShortestSubArray
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     FindShortestSubArray(new int[] { 1, 2, 2, 3, 1 });
        // }
        public int FindShortestSubArray(int[] nums)
        {
            int numberMaxFrequence = 1;
            Dictionary<int, Data> dict = new Dictionary<int, Data>();
            Data d;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    d = dict[nums[i]];
                    d.endIndex = i;
                    d.frequency++;
                    dict[nums[i]] = d;
                    if (d.frequency > numberMaxFrequence)
                    {
                        numberMaxFrequence = d.frequency;
                    }
                }
                else
                {
                    d = new Data();
                    d.startIndex = i;
                    d.endIndex = i;
                    d.frequency = 1;
                    dict.Add(nums[i], d);
                }
            }
            // return dict.Values.Where(x => x.frequency == dict.Values.Select(z => z.frequency).Max()).Min(x => x.endIndex - x.startIndex) + 1;
            return dict.Values.Where(x => x.frequency == numberMaxFrequence).Min(x => x.endIndex - x.startIndex) + 1;
        }
        public struct Data
        {
            public int startIndex;
            public int endIndex;
            public int frequency;
        }
    }
    // @lc code=end

}