/*
 * @lc app=leetcode id=1025 lang=csharp
 *
 * [1025] Divisor Game
 */
namespace DivisiorGame
{
    // @lc code=start
    public class Solution
    {
        public bool DivisorGame(int N)
        {
            //递归
            return N % 2 == 0;
        }
    }
    // @lc code=end

}