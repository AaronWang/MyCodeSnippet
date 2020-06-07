using System.Linq;
/*
 * @lc app=leetcode id=717 lang=csharp
 *
 * [717] 1-bit and 2-bit Characters
 */
namespace IsOneBitCharacter
{
    // @lc code=start
    public class Solution
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length == 1) return true;
            if (bits[bits.Length - 2] == 0) return true;
            else
            {
                //can it be decode when remove last two bit
                //if yes, return false, if no return true;
                // if it has odd 1 befoer second last, it can't be decoded,
                // ....0111 10  odd
                //.....0011 10  even

                int count = 0;
                for (int i = bits.Length - 3; i >= 0; i--)
                {
                    if (bits[i] == 1)
                        count++;
                    else break;
                }
                if (count % 2 == 1) return true;
                else return false;
            }
        }
    }
    // @lc code=end

}