using System.Collections.Specialized;
using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=1046 lang=csharp
 *
 * [1046] Last Stone Weight
 */
namespace LastStoneWeight
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });
        // }
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1) return stones[0];
            if (stones.Length == 2) return Math.Abs(stones[0] - stones[1]);
            Array.Sort(stones);
            List<int> list = new List<int>();
            list.AddRange(stones);
            int largest, secondLargest, smash;
            while (list.Count > 1)
            {
                largest = list.Last();
                list.Remove(largest);
                secondLargest = list.Last();
                list.Remove(secondLargest);
                smash = largest - secondLargest;
                if (smash != 0)
                {
                    int index = list.BinarySearch(smash);
                    if (index < 0) index = ~index;
                    list.Insert(index, smash);
                }
            }
            if (list.Count == 0) return 0;
            return list.First();
        }
    }
    // @lc code=end

}