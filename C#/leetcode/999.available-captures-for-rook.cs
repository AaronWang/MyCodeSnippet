/*
 * @lc app=leetcode id=999 lang=csharp
 *
 * [999] Available Captures for Rook
 */
using System;
using System.Linq;

namespace numrookcaptures
{
    // @lc code=start
    public class Solution
    {

        // public void MainTest(string[] args)
        // {
        //     char[][] board = new char[][]{
        //         new char[]{ '.','.','.','.','.','.','.','.' },
        //         new char[]{ '.','.','.','p','.','.','.','.' },
        //         new char[]{ '.','.','.','R','.','.','.','p' },
        //         new char[]{ '.','.','.','.','.','.','.','.' },
        //         new char[]{ '.','.','.','.','.','.','.','.' },
        //         new char[]{ '.','.','.','p','.','.','.','.' },
        //         new char[]{ '.','.','.','.','.','.','.','.' },
        //         new char[]{ '.','.','.','.','.','.','.','.' }};
        //     NumRookCaptures(board);
        // }
        public int NumRookCaptures(char[][] board)
        {
            int i = 0, j = 0;
            int result = 0;
            for (i = 0; i < 8; i++)
            {
                if (board[i].Contains('R'))
                {
                    // j = board[i].IndexOf('R');
                    j = Array.FindIndex(board[i], x => x == 'R');
                    break;
                }
            }
            // Console.WriteLine(i,j);
            int a, b, c, d;
            int a1 = 0, b1 = 0, c1 = 0, d1 = 0;
            for (int s = 1; s < 7; s++)
            {
                a = j - s;
                b = i - s;
                c = j + s;
                d = i + s;
                //move a left,b up,c right, d down
                //a1,b1,c1,d1, reached something, stop moving forwards,
                if (a < 0 && b < 0 && c >= 8 && d >= 8)
                    break;
                if (a1 == 0 && a > 0)
                {
                    if (board[i][a] == 'p')
                    {
                        result++; a1 = 1;
                    }
                    else if (board[i][a] == 'B')
                    {
                        a1 = 1;
                    }
                }
                if (b1 == 0 && b > 0)
                {
                    if (board[b][j] == 'p')
                    {
                        result++; b1 = 1;
                    }
                    else if (board[b][j] == 'B')
                    {
                        b1 = 1;
                    }
                }
                if (c1 == 0 && c < 8)
                {
                    if (board[i][c] == 'p')
                    {
                        result++; c1 = 1;
                    }
                    else if (board[i][c] == 'B')
                    {
                        c1 = 1;
                    }
                }
                if (d1 == 0 && d < 8)
                {
                    if (board[d][j] == 'p')
                    {
                        result++; d1 = 1;
                    }
                    else if (board[d][j] == 'B')
                    {
                        d1 = 1;
                    }
                }
            }
            return result;
        }
    }
    // @lc code=end

}