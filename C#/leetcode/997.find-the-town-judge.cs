using System.Collections.Generic;
/*
 * @lc app=leetcode id=997 lang=csharp
 *
 * [997] Find the Town Judge
 */
namespace FindJudge
{
    // @lc code=start
    public class Solution
    {
        public int FindJudge(int N, int[][] trust)
        {
            // 3 \n [[1,3],[2,3],[3,1]]
            // 3 \n [[1,2],[2,3]]
            // 1 \n []
            // 2 \n []
            if (trust.Length == 0)
            {
                if (N > 1) return -1;
                if (N == 1) return 1;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < trust.Length; i++)
            {
                if (dict.ContainsKey(trust[i][0]))
                    dict[trust[i][0]] = 0;
                else dict.Add(trust[i][0], 0);
                if (!dict.ContainsKey(trust[i][1])) dict.Add(trust[i][1], 1);
            }
            foreach (int i in dict.Keys)
            {
                if (dict[i] == 1)
                {
                    int count = 0;
                    for (int j = 0; j < trust.Length; j++)
                        if (trust[j][1] == i) count++;
                    if (count == N - 1)
                        return i;
                }
            }
            return -1;
        }
    }
    // @lc code=end

}