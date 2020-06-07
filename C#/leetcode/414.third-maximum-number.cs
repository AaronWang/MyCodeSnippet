using System;
using System.Collections.Generic;
/*
* @lc app=leetcode id=414 lang=csharp
*
* [414] Third Maximum Number
*/
namespace thirdMax
{
    // @lc code=start
    public class Solution
    {
        public void MainTest(string[] args)
        {
            // ThirdMax(new int[] { -2147483648, 1, 2 });
            // ThirdMax(new int[] { 2, 2, 3, 1 });
        }
        public int ThirdMax(int[] nums)
        {
            int maximum, second, third;
            maximum = int.MinValue;
            second = int.MinValue;
            third = int.MinValue;
            HashSet<int> hs = new HashSet<int>();
            bool findThird = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!findThird)
                {
                    if (!hs.Contains(nums[i]))
                        hs.Add(nums[i]);
                    if (hs.Count > 2)
                        findThird = true;
                }
                if (maximum < nums[i])
                {
                    third = second;
                    second = maximum;
                    maximum = nums[i];
                }
                else if (second < nums[i] && maximum > nums[i])
                {
                    third = second;
                    second = nums[i];
                }
                else if (third < nums[i] && second > nums[i])
                { third = nums[i]; }
            }
            return findThird ? third : maximum;
        }
    }
    // @lc code=end

}