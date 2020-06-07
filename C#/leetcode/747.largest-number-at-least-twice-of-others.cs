/*
 * @lc app=leetcode id=747 lang=csharp
 *
 * [747] Largest Number At Least Twice of Others
 */
namespace DominantIndex
{
    // @lc code=start
    public class Solution
    {
        // [0,0,3,2]
        //[0,2,3,0]

        public int DominantIndex(int[] nums)
        {
            int max = int.MinValue;
            bool result = false;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    if (nums[i] >= max * 2)
                        result = true;
                    else result = false;
                    max = nums[i];
                    index = i;
                }
                else
                {
                    if (nums[i] * 2 <= max && result == true)
                        result = true;
                    else result = false;
                }
            }
            if (result) return index;
            else return -1;
        }
    }
    // @lc code=end

}