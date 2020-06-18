/*
 * @lc app=leetcode id=892 lang=csharp
 *
 * [892] Surface Area of 3D Shapes
 */
namespace SurfaceArea
{
    // @lc code=start
    public class Solution
    {
        public int SurfaceArea(int[][] grid)
        {
            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    sum += CubesSurface(grid, i, j);
                }
            }
            return sum;
        }
        public int CubesSurface(int[][] grid, int i, int j)
        {
            int up, down, left, right;
            if (grid[i][j] == 0) return 0;
            if (i - 1 >= 0) up = grid[i][j] - grid[i - 1][j];
            else up = grid[i][j];

            if (j - 1 >= 0) left = grid[i][j] - grid[i][j - 1];
            else left = grid[i][j];
            if (i + 1 < grid.Length) down = grid[i][j] - grid[i + 1][j];
            else down = grid[i][j];
            if (j + 1 < grid.Length) right = grid[i][j] - grid[i][j + 1];
            else right = grid[i][j];

            up = up < 0 ? 0 : up;
            down = down < 0 ? 0 : down;
            left = left < 0 ? 0 : left;
            right = right < 0 ? 0 : right;
            return up + down + left + right + 2;
        }
    }
    // @lc code=end

}