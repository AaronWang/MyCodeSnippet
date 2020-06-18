using System.Linq;
/*
 * @lc app=leetcode id=925 lang=csharp
 *
 * [925] Long Pressed Name
 */
namespace IslongPressedName
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     IsLongPressedName("alex", "aaleex");
        // }
        public bool IsLongPressedName(string name, string typed)
        {
            if (name[0] != typed[0]) return false;
            int nameIndex, typedIndex;
            nameIndex = 0;
            typedIndex = 0;
            while (nameIndex < name.Length && typedIndex < typed.Length)
            {
                if (name[nameIndex] == typed[typedIndex])
                {
                    nameIndex++;
                    typedIndex++;
                }
                else
                {
                    if (typed[typedIndex] == name[nameIndex - 1])
                        typedIndex++;
                    else return false;
                }
            }
            if (nameIndex == name.Length)
            {
                if (typedIndex == typed.Length)
                    return true;
                else
                {
                    if (typed.Substring(typedIndex, typed.Length - typedIndex).Where(x => x != name.Last()).Count() == 0)
                        return true;
                    else return false;
                }

            }
            return false;
        }
    }
    // @lc code=end

}