using System.Xml;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=1394 lang=csharp
 *
 * [1394] Find Lucky Integer in an Array
 */

using System;

namespace findlucky
{
    // @lc code=start
    public class Solution
    {
        public void MainTest(string[] args)
        {
            FindLucky(new int[] { 1, 2, 2, 3, 3, 3 });

        }
        public int FindLucky(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
                if (dictionary.ContainsKey(arr[i]))
                    dictionary[arr[i]]++;
                else dictionary.Add(arr[i], 1);

            if (dictionary.Where((x, i) => x.Value == x.Key).ToArray().Length == 0)
                return -1;
            else
                return dictionary.Where((x, i) => x.Value == x.Key).Select(x => x.Value).Max();
        }
    }
    // @lc code=end

}