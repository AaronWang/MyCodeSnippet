/*
 * @lc app=leetcode id=953 lang=csharp
 *
 * [953] Verifying an Alien Dictionary
 */
using System.Collections.Generic;
using System.Linq;

namespace IsAlienSorted
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     IsAlienSorted(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
        // }

        //  解法: 按照第一个字符分组。然后查看第一个字符的排序
        // 如果 字符串为空，  空字符串在前 true， 空字符串在后 false；
        public bool IsAlienSorted(string[] words, string order)
        {

            // ["word","world","row"]\n "worldabcefghijkmnpqstuvxyz"
            // ["app","apple"]\n "abcdefghijklmnopqrstuvwxyz"
            // ["apple","app"]\n "abcdefghijklmnopqrstuvwxyz"
            // ["word","world","row"]\n"worldabcefghijkmnpqstuvxyz"

            List<List<string>> listStrings = new List<List<string>>();
            List<string> list = new List<string>();
            list.AddRange(words);
            listStrings.Add(list);
            int index = 0;

            while (listStrings.Count != 0)
            {
                list = listStrings.First();
                listStrings.Remove(list);
                if (list.Count == 1) continue;
                list.Distinct();
                bool checkEmptyString = false;

                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].Length == 0 && checkEmptyString == true)
                        return false;
                    if (list[i].Length > 0 || checkEmptyString == false)
                        checkEmptyString = true;// none emptyString appear
                }
                list = list.Where(x => x.Length != 0).ToList();
                var split = list.GroupBy(x => x.First());
                index = -2;
                foreach (var item in split)
                {
                    if (order.IndexOf(item.Key) < index) return false;
                    else index = order.IndexOf(item.Key);
                }
                var tt = split.Select(g => g.Select(c =>
                {
                    return c.Remove(0, 1);
                }).ToList()).ToArray();
                listStrings.AddRange(tt);
            }
            return true;
        }
    }
    // @lc code=end

}