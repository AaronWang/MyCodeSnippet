using System.Collections.Generic;
/*
 * @lc app=leetcode id=1346 lang=csharp
 *
 * [1346] Check If N and Its Double Exist
 */
namespace checkifExist
{
    // @lc code=start
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (hs.Contains(arr[i])) continue;
                else hs.Add(arr[i]);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] || 2 * arr[i] == arr[j])
                        return true;
                }

            }
            return false;
        }
    }
    // @lc code=end

}