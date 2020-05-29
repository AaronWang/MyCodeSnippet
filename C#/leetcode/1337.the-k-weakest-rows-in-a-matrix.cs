using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=1337 lang=csharp
 *
 * [1337] The K Weakest Rows in a Matrix
 */

// @lc code=start

//sortedlist 老版本不能使用linq
// //转换方法 
// 1.
// Cast<string>()
// SortedList sl = new SortedList();
// sl.Add("foo", "baa");
// var baas = sl.Values.Cast<string>().Where(s => s == "baa");
// 2.
// normalList = sortedList.Items;
// 3.
// List<int> list = sortedList.Values.ToList();
namespace kweakestrows{
public class Solution
{
    public struct Row
    {
        public Row(int i, int j)
        {
            row = i;
            soldiers = j;
        }
        public int row;
        public int soldiers;
    }
    public int[] KWeakestRows(int[][] mat, int k)
    {
        int[] weakest = new int[mat.Length];
        int soldiers = 0;
        int j = 0;
        List<Row> list = new List<Row>();

        for (int i = 0; i < mat.Length; i++)
        {
            soldiers = 0;
            for (j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1)
                    soldiers++;
                else
                    break;
            list.Add(new Row(i, soldiers));
        }
        // Array.Sort(list, Row.soldiers);
        return list.OrderBy(x => x.soldiers).Select(x=>x.row).Take(k).ToArray();
    }
}
// @lc code=end
}