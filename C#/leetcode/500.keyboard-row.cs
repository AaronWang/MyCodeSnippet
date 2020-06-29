using System.Linq;
/*
 * @lc app=leetcode id=500 lang=csharp
 *
 * [500] Keyboard Row
 */
using System.Collections.Generic;

namespace FindWords
{
    // @lc code=start
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> row1 = new HashSet<char>();
            row1.Add('Q'); row1.Add('q');
            row1.Add('W'); row1.Add('w');
            row1.Add('E'); row1.Add('e');
            row1.Add('R'); row1.Add('r');
            row1.Add('T'); row1.Add('t');
            row1.Add('Y'); row1.Add('y');
            row1.Add('U'); row1.Add('u');
            row1.Add('I'); row1.Add('i');
            row1.Add('O'); row1.Add('o');
            row1.Add('P'); row1.Add('p');
            HashSet<char> row2 = new HashSet<char>();
            row2.Add('A'); row2.Add('a');
            row2.Add('S'); row2.Add('s');
            row2.Add('D'); row2.Add('d');
            row2.Add('F'); row2.Add('f');
            row2.Add('G'); row2.Add('g');
            row2.Add('H'); row2.Add('h');
            row2.Add('J'); row2.Add('j');
            row2.Add('K'); row2.Add('k');
            row2.Add('L'); row2.Add('l');
            HashSet<char> row3 = new HashSet<char>();
            row3.Add('Z'); row3.Add('z');
            row3.Add('X'); row3.Add('x');
            row3.Add('C'); row3.Add('c');
            row3.Add('V'); row3.Add('v');
            row3.Add('B'); row3.Add('b');
            row3.Add('N'); row3.Add('n');
            row3.Add('M'); row3.Add('m');
            bool a, b, c;
            IList<string> list = new List<string>();
            foreach (string s in words)
            {
                a = false;
                b = false;
                c = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (row1.Contains(s[i]))
                        a = true;
                    if (row2.Contains(s[i]))
                        b = true;
                    if (row3.Contains(s[i]))
                        c = true;
                    if (a && b || b && c || a && c)
                    {
                        break;
                    }
                }
                if (a && !b && !c || !a && b && !c || !a && !b && c)
                    list.Add(s);
            }
            return list.ToArray();
        }
    }
    // @lc code=end

}