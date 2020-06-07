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
        public bool CheckStraightLine(int[][] coordinates)
        {
            // [[0,0],[0,1],[0,-1]]

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
            b = (y1 - y2 * x1 / (double)x2) / (1 - x1 / (double)x2);
            a = (y1 - b) / x1;
            for (int i = 2; i < coordinates.Length; i++)
            {
                if (a != 0 && coordinates[i][1] != a * coordinates[i][0] + b)
                    return false;
                if (a == 0 && !((coordinates[i][0] == coordinates[i - 1][0] && coordinates[i - 1][0] == coordinates[i - 2][0]) || (coordinates[i][1] == coordinates[i - 1][1] && coordinates[i - 1][1] == coordinates[i - 2][1])))
                    return false;
            }
            return true;
        }
    }
    // @lc code=end
}