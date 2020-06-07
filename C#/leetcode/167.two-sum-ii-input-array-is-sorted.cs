/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input array is sorted
 */
namespace twosum2
{
    // @lc code=start
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > target) continue;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] > target) break;
                    if (numbers[i] + numbers[j] == target)
                    { return new int[] { i + 1, j + 1 }; }
                }
            }
            return null;
        }
    }
    // @lc code=end

}