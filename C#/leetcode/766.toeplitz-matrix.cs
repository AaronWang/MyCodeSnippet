/*
 * @lc app=leetcode id=766 lang=csharp
 *
 * [766] Toeplitz Matrix
 */
namespace istoeplitzmatrix
{
    // @lc code=start
    public class Solution
    {
        // 1234
        // 5123
        // 9512
        // 11,74,0,93
        // 40,11,74,7
        // [[11,74,0,93],[40,11,74,7]]

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int m, n;
            for (int row = 0; row < matrix.Length; row++)
            {
                m = row; n = 0;
                while (n < matrix[0].Length && m < matrix.Length)
                {
                    if (matrix[m][n] == matrix[row][0])
                    {
                        m++;
                        n++;
                    }
                    else return false;
                }
            }
            for (int column = 0; column < matrix[0].Length; column++)
            {
                m = 0; n = column;
                while (n < matrix[0].Length && m < matrix.Length)
                {
                    if (matrix[m][n] == matrix[0][column])
                    {
                        m++;
                        n++;
                    }
                    else return false;
                }
            }
            return true;
        }
    }
    // @lc code=end

}