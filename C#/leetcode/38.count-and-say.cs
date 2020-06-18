/*
 * @lc app=leetcode id=38 lang=csharp
 *
 * [38] Count and Say
 */
namespace countAndSay
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     CountAndSay(4);
        // }
        public string CountAndSay(int n)
        {
            if (n <= 1) return "1";
            if (n == 2) return "11";
            string oldString = "11";
            string newString = "";
            int count = 1;
            for (int i = 2; i < n; i++)
            {
                newString = "";
                count = 1;
                for (int j = 0; j < oldString.Length - 1; j++)
                {
                    if (oldString[j] != oldString[j + 1])
                    {
                        newString += count.ToString() + oldString[j];
                        count = 1;
                    }
                    else count++;
                    if (j == oldString.Length - 2)
                        newString += count.ToString() + oldString[j + 1];
                }
                oldString = newString;
            }
            return oldString;
        }
    }
    // @lc code=end

}