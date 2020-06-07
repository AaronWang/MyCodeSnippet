/*
 * @lc app=leetcode id=830 lang=csharp
 *
 * [830] Positions of Large Groups
 */
using System.Collections.Generic;

namespace LargeGroupPositions
{
    // @lc code=start
    public class Solution
    {
        // "aaa"
        // "abc"
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            List<IList<int>> list = new List<IList<int>>();
            if (S.Length < 3) return list;
            IList<int> subList = new List<int>();
            int consecutive = 1;
            int start;
            start = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == S[i + 1])
                {
                    consecutive++;
                }
                else
                {
                    if (consecutive >= 3)
                    {
                        subList.Add(start); subList.Add(i);
                        list.Add(subList);
                        subList = new List<int>();
                    }
                    start = i + 1;
                    consecutive = 1;
                }
            }
            if (consecutive >= 3)
            {
                subList.Add(start); subList.Add(S.Length - 1);
                list.Add(subList);
            }
            return list;
        }
    }
    // @lc code=end

}