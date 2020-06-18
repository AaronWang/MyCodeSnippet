using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Linq;
/*
* @lc app=leetcode id=914 lang=csharp
*
* [914] X of a Kind in a Deck of Cards
*/
namespace hasgroupSizeX
{
    // @lc code=start
    public class Solution
    {

        // [1,1,1,1,2,2,2,2,2,2]
        // [1,1,1,2,2,2,3,3]
        // [1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3]

        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int i;
            for (i = 0; i < deck.Length; i++)
            {
                if (dict.ContainsKey(deck[i]))
                    dict[deck[i]]++;
                else
                    dict.Add(deck[i], 1);
            }
            int min = dict.Values.Min();
            int max = dict.Values.Max();
            if (min < 2) return false;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value % min != 0)
                {
                    for (i = 2; i < min / 2; i++)
                    {
                        if (pair.Value % i == 0 && min % i == 0)
                        { break; }
                    }
                    if (i > min / 2)
                        return false;
                    min = i;
                }
            }
            return true;
        }
    }
    // @lc code=end

}