using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=599 lang=csharp
 *
 * [599] Minimum Index Sum of Two Lists
 */
namespace FindRestaurant
{
    // @lc code=start
    public class Solution
    {
        // ["Shogun","Tapioca Express","Burger King","KFC"]\n["KFC","Burger King","Tapioca Express","Shogun"]
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                dictionary.Add(list1[i], -1);
            }
            for (int j = 0; j < list2.Length; j++)
            {
                if (dictionary.ContainsKey(list2[j]))
                {
                    dictionary[list2[j]] = j;
                }
            }
            for (int i = 0; i < list1.Length; i++)
            {
                if (dictionary[list1[i]] == -1)
                    dictionary.Remove(list1[i]);
                else
                    dictionary[list1[i]] += i;
            }
            int tmp = dictionary.Values.Min();
            return dictionary.Where(x => x.Value == tmp).OrderBy(x => x.Value).Select(x => x.Key).ToArray();
        }
    }
    // @lc code=end

}