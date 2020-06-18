/*
 * @lc app=leetcode id=657 lang=csharp
 *
 * [657] Robot Return to Origin
 */
namespace JudgeCircle
{
    // @lc code=start
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int i, j;
            i = 0;
            j = 0;
            for (int m = 0; m < moves.Length; m++)
            {
                switch (moves[m])
                {
                    case 'L':
                        i++;
                        break;
                    case 'R':
                        i--;
                        break;
                    case 'U':
                        j++;
                        break;
                    case 'D':
                        j--;
                        break;
                }
            }
            if (i == 0 && j == 0)
                return true;
            else return false;
        }
    }
    // @lc code=end

}