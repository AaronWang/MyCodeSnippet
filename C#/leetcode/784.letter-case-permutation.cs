/*
 * @lc app=leetcode id=784 lang=csharp
 *
 * [784] Letter Case Permutation
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LetterCasePermutation
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     LetterCasePermutation("a1b2");
        // }
        public IList<string> LetterCasePermutation(string S)
        {
            List<int> letterPosition = new List<int>();
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder(S);
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] >= 'a' && S[i] <= 'z' || S[i] >= 'A' && S[i] <= 'Z')
                    letterPosition.Add(i);
            }
            if (letterPosition.Count == 0) { result.Add(S); return result; }
            var test = GetPermutation(new char[] { '1', '0' }, letterPosition.Count);
            foreach (var items in test)
            {
                for (int i = 0; i < items.Count(); i++)
                {
                    if (items.ToArray()[i] == '1')
                        sb[letterPosition[i]] = char.ToUpper(sb[letterPosition[i]]);
                    else
                        sb[letterPosition[i]] = char.ToLower(sb[letterPosition[i]]);
                }
                result.Add(sb.ToString());
            }
            return result;
        }
        public static IEnumerable<IEnumerable<T>> GetPermutation<T>(IEnumerable<T> list, int length)
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutation(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
    // @lc code=end

}