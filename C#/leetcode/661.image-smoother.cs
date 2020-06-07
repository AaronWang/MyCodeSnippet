/*
 * @lc app=leetcode id=661 lang=csharp
 *
 * [661] Image Smoother
 */
namespace imagesmoother
{
    // @lc code=start
    public class Solution
    {
        // [[2,3,4],
        // [5,6,7],
        // [8,9,10],
        // [11,12,13],
        // [14,15,16]]
        // public void MainTest(string[] args)
        // {
        //     ImageSmoother(new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7 }, new int[] { 8, 9, 10 } });
        // }
        public int[][] ImageSmoother(int[][] M)
        {
            int[][] result = new int[M.Length][];
            int sum = 0;
            int count = 0;
            for (int row = 0; row < M.Length; row++)
            {
                result[row] = new int[M[row].Length];
                for (int column = 0; column < M[row].Length; column++)
                {
                    count = 1;
                    sum = M[row][column];
                    if (checkEdge(M, row - 1, column - 1)) { count++; sum += M[row - 1][column - 1]; }
                    if (checkEdge(M, row - 1, column)) { count++; sum += M[row - 1][column]; }
                    if (checkEdge(M, row - 1, column + 1)) { count++; sum += M[row - 1][column + 1]; }
                    if (checkEdge(M, row, column - 1)) { count++; sum += M[row][column - 1]; }
                    if (checkEdge(M, row, column + 1)) { count++; sum += M[row][column + 1]; }
                    if (checkEdge(M, row + 1, column - 1)) { count++; sum += M[row + 1][column - 1]; }
                    if (checkEdge(M, row + 1, column)) { count++; sum += M[row + 1][column]; }
                    if (checkEdge(M, row + 1, column + 1)) { count++; sum += M[row + 1][column + 1]; }
                    result[row][column] = sum / count;
                }
            }
            return result;
        }
        public bool checkEdge(int[][] M, int row, int column)
        {
            if (row >= 0 && row < M.Length && column >= 0 && column < M[row].Length)
                return true;
            else return false;
        }
    }
    // @lc code=end

}