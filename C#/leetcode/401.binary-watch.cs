using System.Threading.Tasks;
using System.Reflection;
using System.Linq;
using System.Xml.Schema;
/*
 * @lc app=leetcode id=401 lang=csharp
 *
 * [401] Binary Watch
 */
using System.Collections.Generic;
using System.Text;
using System;

namespace ReadBinaryWatch
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     var tmp = ReadBinaryWatch(0);
        //     // var tmp = ReadBinaryWatch(2);
        //     foreach (var s in tmp)
        //     {
        //         Console.WriteLine(s.ToString());
        //     }
        //     // ["0:03","0:05","0:06","0:09","0:10","0:12","0:17","0:18","0:20","0:24","0:33","0:34","0:36","0:40","0:48","1:01","1:02","1:04","1:08","1:16","1:32","2:01","2:02","2:04","2:08","2:16","2:32","3:00","4:01","4:02","4:04","4:08","4:16","4:32","5:00","6:00","8:01","8:02","8:04","8:08","8:16","8:32","9:00","10:00"]
        // }
        public IList<string> ReadBinaryWatch(int num)
        {
            if (num == 0) return new string[] { "0:00" };
            IList<string> list = new List<string>();
            string h, m;
            char[] s = new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
            int[] index = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // int[] index = new int[4] { 1, 2, 3, 4 };
            IEnumerable<IEnumerable<int>> test = GetKCombination<int>(index, num);
            // foreach (var items in test)
            // {
            //     Console.Write("{");
            //     foreach (var item in items)
            //     {
            //         Console.Write("  " + item + " ");
            //     }
            //     Console.WriteLine("}");
            // }
            // list = Combination(new string(s));
            list = test.Select(g =>
            {
                string newString = "";
                foreach (int i in g)
                    s[i] = '1';

                newString = new string(s);
                s = new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
                return newString;

            }).ToList();
            list = list.Select(x =>
            {
                int tmp = Convert.ToInt16(new string(x.Take(4).ToArray()), 2);
                if (tmp >= 12) return "";
                else h = tmp.ToString();
                tmp = Convert.ToInt16(new string(x.Skip(4).ToArray()), 2);
                if (tmp >= 60) return "";
                else m = tmp.ToString();

                if (m.Length == 1)
                    m = '0' + m;
                return h + ':' + m;
            }).Where(x => !x.Equals("")).OrderBy(x => x.Length == 4 ? '0' + x : x).ToList();

            return list;
        }
        public IEnumerable<IEnumerable<T>> GetKCombination<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombination(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
    // @lc code=end
}