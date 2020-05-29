/*
 * @lc app=leetcode id=1260 lang=csharp
 *
 * [1260] Shift 2D Grid
 */
using System.Collections.Generic;
using System.Linq;

namespace shiftgrid
{
    // @lc code=start
    public class Solution
    {
        // public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < grid.Length; i++)
            {
                list.Add(new List<int>());
                for (int j = 0; j < grid[i].Length; j++)
                {
                    list[i].Add(grid[i][j]);
                }
            }
            for (int n = 0; n < k; n++)
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = grid[i].Length - 1 - 1; j >= 0; j--)
                        list[i][j + 1] = grid[i][j];
                    if (i + 1 < grid.Length)
                        list[i + 1][0] = grid[i][grid[i].Length - 1];
                }
                list[0][0] = grid[grid.Length-1][grid[0].Length-1];
                grid = list.Select(x => x.ToArray()).ToArray();
            }
            // list = grid.Select(x=>x.ToList<int>()).ToList();
            return list;
            // return list;
            //list of list to array of array
            // int[][] arrays = lst.Select(a => a.ToArray()).ToArray();

        }
    }
    // @lc code=end

}