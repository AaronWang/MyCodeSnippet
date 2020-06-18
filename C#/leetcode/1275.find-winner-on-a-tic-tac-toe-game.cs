/*
 * @lc app=leetcode id=1275 lang=csharp
 *
 * [1275] Find Winner on a Tic Tac Toe Game
 */
namespace Tictactoe
{
    // @lc code=start
    public class Solution
    {
        public string Tictactoe(int[][] moves)
        {
            int[] aRow = new int[3] { 0, 0, 0 };
            int[] aCol = new int[3] { 0, 0, 0 };
            int ar = 0;
            int al = 0;
            int[] bRow = new int[3] { 0, 0, 0 };
            int[] bCol = new int[3] { 0, 0, 0 };
            int br = 0;
            int bl = 0;
            int r = 0;
            int c = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                r = moves[i][0];
                c = moves[i][1];
                if (i % 2 == 0)
                {
                    if (++aRow[r] == 3 || ++aCol[c] == 3 || r == c && ++ar == 3 || r + c == 2 && ++al == 3)
                        return "A";
                }
                else
                {
                    if (++bRow[r] == 3 || ++bCol[c] == 3 || r == c && ++br == 3 || r + c == 2 && ++bl == 3)
                        return "B";
                }
            }
            return moves.Length == 9 ? "Draw" : "Pending";
        }
    }
    // @lc code=end

}