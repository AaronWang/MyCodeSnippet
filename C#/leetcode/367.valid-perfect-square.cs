/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 */
namespace IsPerfectSquare
{
    // @lc code=start
    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            long root = num;
            while (root * root > num)
            {
                root = (root + num / root) / 2;
            }
            root = (int)root;
            return root * root == num;
        }
    }
    // @lc code=end

}