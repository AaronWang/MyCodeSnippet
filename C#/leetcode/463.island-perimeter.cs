/*
 * @lc app=leetcode id=463 lang=csharp
 *
 * [463] Island Perimeter
 */
namespace IslandPerimeter
{
    // @lc code=start
    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                        sum += GetSurround(grid, i, j);
                }
            }
            return sum;
        }
        public int GetSurround(int[][] grid, int row, int col)
        {
            int surround = 0;
            if (row - 1 < 0 || grid[row - 1][col] != 1) surround++;
            if (row + 1 >= grid.Length || grid[row + 1][col] != 1) surround++;
            if (col - 1 < 0 || grid[row][col - 1] != 1) surround++;
            if (col + 1 >= grid[0].Length || grid[row][col + 1] != 1) surround++;
            return surround;
        }
    }
    // @lc code=end

}