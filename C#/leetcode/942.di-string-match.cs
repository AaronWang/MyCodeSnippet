/*
 * @lc app=leetcode id=942 lang=csharp
 *
 * [942] DI String Match
 */
namespace DiStringMatch
{
    // @lc code=start
    public class Solution
    {
        public int[] DiStringMatch(string S)
        {
            int[] result = new int[S.Length + 1];
            int N = S.Length;
            int start = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                    result[i] = start++;
                if (S[i] == 'D')
                    result[i] = N--;
            }
            if (S[S.Length - 1] == 'I')
                result[S.Length] = start++;
            if (S[S.Length - 1] == 'D')
                result[S.Length] = N--;

            return result;
        }
    }
    // @lc code=end

}