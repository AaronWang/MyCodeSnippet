using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=1399 lang=csharp
 *
 * [1399] Count Largest Group
 */
namespace countlargestgroup
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args){
        //     CountLargestGroup(13);
        // }
        public int CountLargestGroup(int n)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int sum, num;
            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                num = i;
                do
                {
                    sum += num % 10;
                    num /= 10;
                } while (num != 0);
                if (dictionary.ContainsKey(sum))
                    dictionary[sum] += 1;
                else dictionary.Add(sum, 1);
            }
            var value = dictionary.Where(x => dictionary.All(y=>x.Value>=y.Value)).Count();
            return value;
        }
    }
    // @lc code=end
}