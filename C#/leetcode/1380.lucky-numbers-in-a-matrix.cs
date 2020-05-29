using System.Collections.Generic;
using System;
using System.Linq;

namespace luckyNumbers{
public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int min, index, j;
        List<int> lucky = new List<int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            min = matrix[i].Min();
            index = Array.IndexOf(matrix[i], min);
            for (j = 0; j < matrix.Length; j++)
            {
                if (matrix[j].Length < index)
                    continue;
                if (min < matrix[j][index])
                    break;
            }
            if (j == matrix.Length)
                lucky.Add(min);
        }
        return lucky.ToArray();
    }
}
// @lc code=end

}