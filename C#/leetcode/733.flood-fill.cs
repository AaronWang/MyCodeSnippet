/*
 * @lc app=leetcode id=733 lang=csharp
 *
 * [733] Flood Fill
 */
namespace FloodFill
{
    // @lc code=start
    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            // [[0,0,0],[0,1,1]] \n 1 \n1 \n1
            if (image == null) return null;
            if (image[sr][sc] == newColor) return image;
            int original;
            original = image[sr][sc];
            image[sr][sc] = newColor;
            if (sr - 1 >= 0 && image[sr - 1][sc] == original) FloodFill(image, sr - 1, sc, newColor);
            if (sr + 1 < image.Length && image[sr + 1][sc] == original) FloodFill(image, sr + 1, sc, newColor);
            if (sc - 1 >= 0 && image[sr][sc - 1] == original) FloodFill(image, sr, sc - 1, newColor);
            if (sc + 1 < image[0].Length && image[sr][sc + 1] == original) FloodFill(image, sr, sc + 1, newColor);
            return image;
        }
    }
    // @lc code=end

}