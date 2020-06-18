/*
 * @lc app=leetcode id=836 lang=csharp
 *
 * [836] Rectangle Overlap
 */
namespace IsRectangleOverlap
{
    // @lc code=start
    public class Solution
    {
        // [7,8,13,15]\n [10,8,12,20]
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            //solution
            if (rec1[0] >= rec2[2] || rec2[0] >= rec1[2]) return false;
            if (rec1[1] >= rec2[3] || rec2[1] >= rec1[3]) return false;
            return true;


            if (checkArea(rec1, rec2[0], rec2[1]) || checkArea(rec1, rec2[2], rec2[3]) || checkArea(rec1, rec2[0], rec2[3]) || checkArea(rec1, rec2[2], rec2[1]))
                return true;
            if (checkArea(rec2, rec1[0], rec1[1]) || checkArea(rec2, rec1[2], rec1[3]) || checkArea(rec2, rec1[0], rec1[3]) || checkArea(rec2, rec1[2], rec1[1]))
                return true;
            if (checkAreaCross(rec1, rec2) || checkAreaCross(rec2, rec1))
                return true;
            return false;
        }
        public bool checkArea(int[] rec1, int x, int y)
        {
            int x1, y1, x2, y2;
            x1 = rec1[0];
            y1 = rec1[1];
            x2 = rec1[2];
            y2 = rec1[3];
            if (x1 < x && x < x2 && y1 < y && y < y2)
                return true;
            else return false;
        }
        public bool checkAreaCross(int[] rec1, int[] rec2)
        {
            if (rec1[0] <= rec2[0] && rec1[2] >= rec2[2] && rec1[1] >= rec2[1] && rec1[3] <= rec2[3])
                return true;
            else return false;
        }
    }
    // @lc code=end

}