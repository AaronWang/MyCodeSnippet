using System.Collections;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Test
    {
        public void MainTest()
        {
            // string s = "abcd";
            // s.Substring(0,);
            int[] source = new int[10];
            int[] destination = new int[10];
            Array.Copy(source, destination, 10);
            Array.Copy(source, 0, destination, 0, 10);

            Array.Fill(new int[10], 1);
            //Linq
            Enumerable.Repeat("value", 10);

            int num = 100;
            long root = num;
            while (root * root > num)
            {
                root = (root + num / root) / 2;
            }
            Console.WriteLine();

            //permutation and combination
            var range = Enumerable.Range(1, 6);
            var result = from d1 in range
                         from d2 in range
                         from d3 in range
                         from d4 in range
                         from d5 in range
                         select new { d1, d2, d3, d4, d5 };


            // DateTime.Parse();
            // DateTime.ParseExact();

            // selectMany的四种用法
            string[] strs = new string[] { "cba", "daf", "ghi" };
            var tmp = strs.SelectMany(s => s).ToArray();
            tmp = strs.SelectMany((s, i) => s.Select(c => (char)(c + 1))).ToArray();
            tmp = strs.SelectMany(s => s, (s, c) => c).ToArray();
            tmp = strs.SelectMany((s, i) => s, (s, c) => c).ToArray();

            // 更改 IComparer的接口后， sortedList 支持重复 key
            SortedList<int, int> list = new SortedList<int, int>();
        }
        public bool PrimeCheck(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public int BitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n = n >> 1;
            }
            return count;
        }
    }
    public class MySort : IComparer
    {
        public int Compare(object x, object y)
        {
            if ((double)x > (double)y) return 1;
            else return -1;
        }
    }
}

