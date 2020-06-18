using System.Linq;
/*
 * @lc app=leetcode id=883 lang=csharp
 *
 * [883] Projection Area of 3D Shapes
 */
namespace ProjectionArea
{
    // @lc code=start
    public class Solution
    {
        public int ProjectionArea(int[][] grid)
        {
            int count = grid.Length * grid.Length;
            int maxCol = 0;
            int maxRow = 0;
            int sumCol = 0;
            int sumRow = 0;
            for (int row = 0; row < grid.Length; row++)
            {
                maxCol = 0;
                maxRow = 0;
                for (int col = 0; col < grid.Length; col++)
                {
                    if (grid[row][col] > maxCol) maxCol = grid[row][col];
                    if (grid[col][row] > maxRow) maxRow = grid[col][row];
                    if (grid[row][col] == 0) count--;
                }
                sumCol += maxCol;
                sumRow += maxRow;
            }
            return count + sumCol + sumRow;
        }
    }
    // @lc code=end

}