using System;
/*
 * @lc app=leetcode id=1232 lang=csharp
 *
 * [1232] Check If It Is a Straight Line
 */
namespace checkstraightLine
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     CheckStraightLine(new int[][] { new int[] { 0, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } });
        //     // CheckStraightLine(new int[][] { new int[] { 2, 4 }, new int[] { 2, 5 }, new int[] { 2, 8 } });
        //     // CheckStraightLine(new int[][] { new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { -4, -7 }, new int[] { 5, 11 } });
        //     // CheckStraightLine(new int[][] { new int[] { -10, 84 }, new int[] { 0, -6 }, new int[] { 7, -69 }, new int[] { -7, 57 },
        //     //  new int[] { 3, -33 }, new int[] { -8, 66 }, new int[] { -12, 102 }, new int[] { 10,  -96} });
        //     // [[9,77],[14,127],[5,37],[-4,-953],[0,-13],[-1,-23],[-10,-113],[-14,-153],[11,97],[12,107],[10,87],[1,-3],[3,17],[-12,-133]]
        // }
        public bool CheckStraightLine(int[][] coordinates)
        {

            if (coordinates.Length <= 2)
            {
                return true;
            }
            // formular y=ax+b;  find a and b from first tow point;
            double a, b;
            // b = y - ax;
            // a = (y - b) / x;
            // b= y-(y-b)/x*x;   here use different x,y  b = y1-(y2-b)/x2*x1
            // b = (y1-y2*x1/x2)/(1-x1/x2);
            int y1, x1, y2, x2;
            x1 = coordinates[0][0];
            y1 = coordinates[0][1];
            x2 = coordinates[1][0];
            y2 = coordinates[1][1];
            // if (x1 == 0)
            //     b = (y1 - y2 * x1 / (double)x2) / (1 - x1 / (double)x2);
            // else
            //     b = (y2 - y1 * x2 / (double)x1) / (1 - x2 / (double)x1);
            if (x1 == x2)
                b = Double.NaN;
            else
                b = (x1 * y2 - x2 * y1) / (x1 - x2);
            if (x1 == 0)
                a = (y2 - b) / x2;
            else
                a = (y1 - b) / x1;

            for (int i = 2; i < coordinates.Length; i++)
            {
                if (!double.IsNaN(a) && !Double.IsInfinity(a) && coordinates[i][1] != a * coordinates[i][0] + b)
                    return false;
                if ((double.IsNaN(a) || Double.IsInfinity(a)) && !((coordinates[i][0] == coordinates[i - 1][0] && coordinates[i - 1][0] == coordinates[i - 2][0]) || (coordinates[i][1] == coordinates[i - 1][1] && coordinates[i - 1][1] == coordinates[i - 2][1])))
                    return false;
            }
            return true;
        }
    }
    // @lc code=end
}