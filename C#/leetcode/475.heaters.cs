using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=475 lang=csharp
 *
 * [475] Heaters
 */
namespace FindRadius
{
    // @lc code=start
    public class Solution
    {

        // [1,2,3,4]\n[1,4]
        // public void MainTest(string[] args)
        // {
        //     FindRadius(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 });
        // }
        public int FindRadius(int[] houses, int[] heaters)
        {
            SortedList<int, int> heatersPosition = new SortedList<int, int>();
            foreach (int item in heaters)
            {
                if (!heatersPosition.ContainsKey(item))
                    heatersPosition.Add(item, item);
            }
            int ans = 0;
            //easy way
            foreach (int house in houses)
            {
                if (heatersPosition.ContainsKey(house))
                    continue;
                heatersPosition.Add(house, house);
                int index = heatersPosition.IndexOfKey(house);
                int leftHeater = 0;
                int rightHeater = 0;
                int minDistance = 0;
                if (index - 1 >= 0)
                    leftHeater = Math.Abs(heatersPosition.Keys[index - 1] - house);
                if (index + 1 < heatersPosition.Count)
                    rightHeater = Math.Abs(heatersPosition.Keys[index + 1] - house);
                if (leftHeater == 0 || rightHeater == 0)
                    minDistance = Math.Max(leftHeater, rightHeater);
                else
                    minDistance = Math.Min(leftHeater, rightHeater);
                ans = Math.Max(ans, minDistance);
                heatersPosition.Remove(house);
            }
            return ans;
            // binary search
            int left, right;
            int mid;
            foreach (int house in houses)
            {
                left = 0;
                right = heatersPosition.Count() - 1;
                while (left < right - 1)
                {
                    mid = left + (right - left) / 2;
                    if ((int)heatersPosition.Keys[mid] > house)
                        right = mid;
                    else left = mid;
                }
                ans = Math.Max(ans, Math.Min(Math.Abs(heatersPosition.Keys[left] - house), Math.Abs(heatersPosition.Keys[right] - house)));
            }
            return ans;
        }
    }
    // @lc code=end

}