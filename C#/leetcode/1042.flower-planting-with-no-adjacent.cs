/*
 * @lc app=leetcode id=1042 lang=csharp
 *
 * [1042] Flower Planting With No Adjacent
 */
using System.Collections.Generic;

namespace GardenNoAdj
{
    // @lc code=start
    public class Solution
    {
        Dictionary<int, HashSet<int>> nodes = new Dictionary<int, HashSet<int>>();
        // Dictionary<int, int> ans = new Dictionary<int, int>();

        public int[] GardenNoAdj(int N, int[][] paths)
        {

            int[] ans = new int[N]; //default 0;

            for (int i = 1; i <= N; i++)
            {
                nodes.Add(i, new HashSet<int>());
                ans[i - 1] = (i - 1) % 4 + 1;
            }
            for (int i = 0; i < paths.Length; i++)
            {
                nodes[paths[i][0]].Add(paths[i][1]);
                nodes[paths[i][1]].Add(paths[i][0]);
            }

            for (int i = 0; i < paths.Length; i++)
            {
                //check conflict
                if (ans[paths[i][0] - 1] == ans[paths[i][1] - 1])
                {
                    int flower = 1;
                    for (flower = 1; flower < 5; flower++)
                    {
                        if (flower == ans[paths[i][1] - 1]) continue;
                        bool sameFlower = false;
                        foreach (int neighour in nodes[paths[i][0]])
                        {
                            if (flower == ans[neighour - 1])
                            {
                                sameFlower = true;
                                break;
                            }
                        }
                        if (sameFlower == false)
                            break;
                    }
                    ans[paths[i][0] - 1] = flower;
                }
            }
            return ans;
        }
    }
    // @lc code=end

}