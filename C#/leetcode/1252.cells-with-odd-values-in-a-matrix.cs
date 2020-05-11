public class Solution
{

    public void main(string[] args)
    {
        int[,] indices = new int[,] { { 0, 1 }, { 1, 1 } };
        // OddCells(2,3,indices);
    }
    public int OddCells(int n, int m, int[][] indices)
    {
        int[,] matrix = new int[n, m];
        int odd = 0;
        // for (int i = 0; i < n; i++)
        //     for (int j = 0; j < m; j++)
        //         matrix[i, j] = 0;
        for (int i = 0; i < indices.Length; i++)
        {
            //row +1
            for (int j = 0; j < m; j++)
            {
                int col = indices[i][0];
                matrix[col, j]++;
                // Console.Write(matrix[col, j]);
            }
            // Console.WriteLine();
            //col +1
            for (int j = 0; j < n; j++)
            {
                int row = indices[i][1];
                matrix[j, row]++;
                // Console.Write(matrix[j, row]);
            }
            // Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

                // Console.Write(matrix[i,j]);
                if (matrix[i, j] % 2 == 1)
                    odd++;
            }

            // Console.WriteLine();
        }
        return odd;
    }
}
// @lc code=end

