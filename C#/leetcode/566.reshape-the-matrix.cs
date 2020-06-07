using System.Linq;
/*
 * @lc app=leetcode id=566 lang=csharp
 *
 * [566] Reshape the Matrix
 */
namespace maatrixReshape
{
    // @lc code=start
    public class Solution
    {
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            if (r * c < nums.Length * nums[0].Length) return nums;
            if (r >= nums.Length && c >= nums[0].Length) return nums;

            int[][] resharp = new int[r][];
            int transferI = 0;
            int transferJ = 0;
            int numberTh = 0;
            for (int i = 0; i < r; i++)
            {
                resharp[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    numberTh = i * c + j;
                    if (numberTh >= nums.Length * nums[0].Length) return resharp;
                    transferJ = numberTh % nums[0].Length;
                    transferI = (numberTh - transferJ) / nums[0].Length;
                    resharp[i][j] = nums[transferI][transferJ];
                }
            }
            // for()
            return resharp;
        }
    }
    // @lc code=end

}