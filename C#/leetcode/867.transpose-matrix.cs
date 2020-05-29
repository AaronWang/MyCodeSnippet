/*
 * @lc app=leetcode id=867 lang=csharp
 *
 * [867] Transpose Matrix
 */
namespace tranpose
{
    // @lc code=start
    public class Solution
    {

        // [[1,2,3],[4,5,6]]
        // 1 2 3
        // 4 5 6
        // expect 14
        // expect 25
        // expect 36

        public int[][] Transpose(int[][] A)
        {
            int row, column;
            row = A.Length;
            column = A[0].Length;
            int[][] B = new int[column][];
            for (int i = 0; i < column; i++)
            {
                B[i] = new int[row];
                for (int j = 0; j < row; j++)
                    B[i][j] = A[j][i];
            }
            return B;
            //only works when row == column
            for (int i = 1; i < A.Length; i++)
            {
                row = i; column = 0;
                while (row < A.Length && column < A.Length)
                {
                    A[row][column] = A[row][column] + A[column][row];
                    A[column][row] = A[row][column] - A[column][row];
                    A[row][column] = A[row][column] - A[column][row];
                    row++;
                    column++;
                }
            }
            return A;
        }
    }
    // @lc code=end

}