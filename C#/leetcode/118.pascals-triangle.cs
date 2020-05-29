/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */
using System.Collections.Generic;

namespace generate
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args){
        //     Generate(3);
        // }
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();
            //for each row
            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                row.Add(1);
                //for each item in row
                for (int j = 1; j <=i; j++)
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
            return list;
        }
    }
    // @lc code=end

}