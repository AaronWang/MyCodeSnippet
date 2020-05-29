using System.Linq;
/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */
using System.Collections.Generic;

namespace getRow
{
    // @lc code=start
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> lastRow = new List<int>();
            rowIndex++;
            IList<IList<int>> list = new List<IList<int>>();
            //for each row
            for (int i = 0; i < rowIndex; i++)
            {
                IList<int> row = new List<int>();
                row.Add(1);
                //for each item in row
                for (int j = 1; j <= i; j++)
                {
                    if (j < i)
                        row.Add(list[i - 1][j - 1] + list[i - 1][j]);
                    else if (j == i)
                    {
                        row.Add(1);
                    }
                }
                list.Add(row);
            }
            lastRow = list.Last();
            return lastRow;
        }
    }
    // @lc code=end

}