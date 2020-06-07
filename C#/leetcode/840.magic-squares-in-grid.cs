/*
 * @lc app=leetcode id=840 lang=csharp
 *
 * [840] Magic Squares In Grid
 */
using System.Collections.Generic;

namespace numMagicSquaresInside
{
    // @lc code=start
    public class Solution
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            // [[5,5,5],[5,5,5],[5,5,5]]

            int count = 0;
            for (int i = 0; i < grid.Length - 2; i++)
            {
                for (int j = 0; j < grid[i].Length - 2; j++)
                {
                    if (IsMagicGrid(grid, i, j))
                        count++;
                }
            }
            return count;
        }
        public bool IsMagicGrid(int[][] grid, int i, int j)
        {
            HashSet<int> set = new HashSet<int>();
            for (int t = 0; t < 3; t++)
            {
                for (int s = 0; s < 3; s++)
                {
                    set.Add(grid[i + t][j + s]);
                }
            }
            for (int t = 1; t < 10; t++)
            {
                if (!set.Contains(t)) return false;
            }
            int tmp = grid[i][j] + grid[i][j + 1] + grid[i][j + 2];
            if (tmp == grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] &&
             tmp == grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] &&
                tmp == grid[i][j] + grid[i + 1][j] + grid[i + 2][j] &&
            tmp == grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] &&
             tmp == grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] &&
               tmp == grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] &&
               tmp == grid[i + 2][j] + grid[i + 1][j + 1] + grid[i][j + 2])

                return true;
            else return false;
        }
    }
    // @lc code=end

}