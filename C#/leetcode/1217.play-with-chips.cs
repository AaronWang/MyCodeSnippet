using System;
/*
 * @lc app=leetcode id=1217 lang=csharp
 *
 * [1217] Play with Chips
 */
namespace mincosttoMoveChips
{
    // @lc code=start
    public class Solution
    {
        public int MinCostToMoveChips(int[] chips)
        {
            //odd = if all move to odd postion
            //eve = if all move to even postion
            int odd = 0, even = 0;
            for (int i = 0; i < chips.Length; i++)
            {
                if (chips[i] % 2 == 0)
                    odd++;
                else even++;
            }

            return Math.Min(odd,even);
        }
    }
    // @lc code=end

}