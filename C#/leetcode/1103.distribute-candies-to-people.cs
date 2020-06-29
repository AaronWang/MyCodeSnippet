/*
 * @lc app=leetcode id=1103 lang=csharp
 *
 * [1103] Distribute Candies to People
 */
namespace DistributeCandies
{
    // @lc code=start
    public class Solution
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] result = new int[num_people];
            int count = 1;
            do
            {
                for (int i = 0; i < num_people; i++)
                {
                    if (candies > count)
                        result[i] += count;
                    else
                    {
                        result[i] += candies;
                        return result;
                    }
                    candies -= count;
                    count++;
                }
            } while (candies > 0);
            return result;
        }
    }
    // @lc code=end

}