/*
 * @lc app=leetcode id=874 lang=csharp
 *
 * [874] Walking Robot Simulation
 */
using System;
using System.Collections.Generic;

namespace RobotSim
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        // [1,2,-2,5,-1,-2,-1,8,3,-1,9,4,-2,3,2,4,3,9,2,-1,-1,-2,1,3,-2,4,1,4,-1,1,9,-1,-2,5,-1,5,5,-2,6,6,7,7,2,8,9,-1,7,4,6,9,9,9,-1,5,1,3,3,-1,5,9,7,4,8,-1,-2,1,3,2,9,3,-1,-2,8,8,7,5,-2,6,8,4,6,2,7,2,-1,7,-2,3,3,2,-2,6,9,8,1,-2,-1,1,4,7] \n[[-57,-58],[-72,91],[-55,35],[-20,29],[51,70],[-61,88],[-62,99],[52,17],[-75,-32],[91,-22],[54,33],[-45,-59],[47,-48],[53,-98],[-91,83],[81,12],[-34,-90],[-79,-82],[-15,-86],[-24,66],[-35,35],[3,31],[87,93],[2,-19],[87,-93],[24,-10],[84,-53],[86,87],[-88,-18],[-51,89],[96,66],[-77,-94],[-39,-1],[89,51],[-23,-72],[27,24],[53,-80],[52,-33],[32,4],[78,-55],[-25,18],[-23,47],[79,-5],[-23,-22],[14,-25],[-11,69],[63,36],[35,-99],[-24,82],[-29,-98],[-50,-70],[72,95],[80,80],[-68,-40],[65,70],[-92,78],[-45,-63],[1,34],[81,50],[14,91],[-77,-54],[13,-88],[24,37],[-12,59],[-48,-62],[57,-22],[-8,85],[48,71],[12,1],[-20,36],[-32,-14],[39,46],[-41,75],[13,-23],[98,10],[-88,64],[50,37],[-95,-32],[46,-91],[10,79],[-11,43],[-94,98],[79,42],[51,71],[4,-30],[2,74],[4,10],[61,98],[57,98],[46,43],[-16,72],[53,-69],[54,-96],[22,0],[-7,92],[-69,80],[68,-73],[-24,-92],[-21,82],[32,-1],[-6,16],[15,-29],[70,-66],[-85,80],[50,-3],[6,13],[-30,-98],[-30,59],[-67,40],[17,72],[79,82],[89,-100],[2,79],[-95,-46],[17,68],[-46,81],[-5,-57],[7,58],[-42,68],[19,-95],[-17,-76],[81,-86],[79,78],[-82,-67],[6,0],[35,-16],[98,83],[-81,100],[-11,46],[-21,-38],[-30,-41],[86,18],[-68,6],[80,75],[-96,-44],[-19,66],[21,84],[-56,-64],[39,-15],[0,45],[-81,-54],[-66,-93],[-4,2],[-42,-67],[-15,-33],[1,-32],[-74,-24],[7,18],[-62,84],[19,61],[39,79],[60,-98],[-76,45],[58,-98],[33,26],[-74,-95],[22,30],[-68,-62],[-59,4],[-62,35],[-78,80],[-82,54],[-42,81],[56,-15],[32,-19],[34,93],[57,-100],[-1,-87],[68,-26],[18,86],[-55,-19],[-68,-99],[-9,47],[24,94],[92,97],[5,67],[97,-71],[63,-57],[-52,-14],[-86,-78],[-17,92],[-61,-83],[-84,-10],[20,13],[-68,-47],[7,28],[66,89],[-41,-17],[-14,-46],[-72,-91],[4,52],[-17,-59],[-85,-46],[-94,-23],[-48,-3],[-64,-37],[2,26],[76,88],[-8,-46],[-19,-68]]
        //5140

        // RobotSim(new int[] { 4, 4, 4, 4 }, new int[][] {
        //     new int[] {0,3 },
        //      });

        // RobotSim(new int[] { -1, 4, 4, 4, 4 }, new int[][] { new int[] { 3, 0 } });
        // RobotSim(new int[] { 1, 2, -2, 5, -1, -2, -1, 8, 3, -1, 9, 4, -2, 3, 2, 4, 3, 9, 2, -1, -1, -2, 1, 3, -2, 4, 1, 4, -1, 1, 9, -1, -2, 5, -1, 5, 5, -2, 6, 6, 7, 7, 2, 8, 9, -1, 7, 4, 6, 9, 9, 9, -1, 5, 1, 3, 3, -1, 5, 9, 7, 4, 8, -1, -2, 1, 3, 2, 9, 3, -1, -2, 8, 8, 7, 5, -2, 6, 8, 4, 6, 2, 7, 2, -1, 7, -2, 3, 3, 2, -2, 6, 9, 8, 1, -2, -1, 1, 4, 7 },
        // new int[][] {
        //     new int[] {-57,-58 }, new int[] { -72,91 }, new int[] {-55,35}, new int[] { -20,29 }, new int[] { 51, 70 },
        //     new int[] { -61, 88 }, new int[] { -62, 99 }, new int[] { 52, 17 }, new int[] { -75, -32 }, new int[] { 91, -22 },
        //     new int[] { 54,33 }, new int[] { -45,-59 }, new int[] { 47,-48 }, new int[] { 53,-98 }, new int[] { -91,83 },
        //     new int[] { 81,12 }, new int[] { -34,-90 }, new int[] { -79,-82 }, new int[] { -15,-86 }, new int[] { -24,66 },
        //     new int[] { -35,35 }, new int[] { 3,31 }, new int[] { 87,93 }, new int[] { 2,-19 }, new int[] { 87,-93},
        //     new int[] { 24,-10 }, new int[] { 84,-53 }, new int[] { 86,87 }, new int[] { -88,-18 }, new int[] { -53,89},
        //     new int[] { 96,66 }, new int[] { -77,-94 }, new int[] { -39,-1 }, new int[] { 89,51 }, new int[] { -23,-72},
        //     new int[] { 27,24 }, new int[] { 53,-80 }, new int[] { 52,-33 }, new int[] { 32,4 }, new int[] { 89,55},
        //     new int[] { -25,18 }, new int[] { -23,47 }, new int[] { 79,-5 }, new int[] { -23,-22 }, new int[] { 14,-25},
        //     new int[] { -11,69 }, new int[] { 63,36 }, new int[] { 35,-99 }, new int[] { -24,84 }, new int[] { -29,-98},
        //     new int[]{ -29, -98 },new int[]{ -50, -70 },new int[]{ 72, 95 },new int[]{ 80, 80 },new int[]{ -68, -40 },new int[]{ 65, 70 },
        //     new int[]{ -92, 78 },new int[]{ -45, -63 },new int[]{ 1, 34 },new int[]{ 81, 50 },new int[]{ 14, 91 },new int[]{ -77, -54 },
        //     new int[]{ 13, -88 },new int[]{ 24, 37 },new int[]{ -12, 59 },new int[]{ -48, -62 },new int[]{ 57, -22 },new int[]{ -8, 85 },
        //     new int[]{ 48, 71 },new int[]{ 12, 1 },new int[]{ -20, 36 },new int[]{ -32, -14 },new int[]{ 39, 46 },new int[]{ -41, 75 },
        //     new int[]{ 13, -23 },new int[]{ 98, 10 },new int[]{ -88, 64 },new int[]{ 50, 37 },new int[]{ -95, -32 },new int[]{ 46, -91 },
        //     new int[]{ 10, 79 },new int[]{ -11, 43 },new int[]{ -94, 98 },new int[]{ 79, 42 },new int[]{ 51, 71 },new int[]{ 4, -30 },
        //     new int[]{ 2, 74 },new int[]{ 4, 10 },new int[]{ 61, 98 },new int[]{ 57, 98 },new int[]{ 46, 43 },new int[]{ -16, 72 },
        //     new int[]{ 53, -69 },new int[]{ 54, -96 },new int[]{ 22, 0 },new int[]{ -7, 92 },new int[]{ -69, 80 },new int[]{ 68, -73 },
        //     new int[]{ -24, -92 },new int[]{ -21, 82 },new int[]{ 32, -1 },new int[]{ -6, 16 },new int[]{ 15, -29 },new int[]{ 70, -66 },
        //     new int[]{ -85, 80 },new int[]{ 50, -3 },new int[]{ 6, 13 },new int[]{ -30, -98 },new int[]{ -30, 59 },new int[]{ -67, 40 },
        //     new int[]{ 17, 72 },new int[]{ 79, 82 },new int[]{ 89, -100 },new int[]{ 2, 79 },new int[]{ -95, -46 },new int[]{ 17, 68 },
        //     new int[]{ -46, 81 },new int[]{ -5, -57 },new int[]{ 7, 58 },new int[]{ -42, 68 },new int[]{ 19, -95 },new int[]{ -17, -76 },
        //     new int[]{ 81, -86 },new int[]{ 79, 78 },new int[]{ -82, -67 },new int[]{ 6, 0 },new int[]{ 35, -16 },new int[]{ 98, 83 },
        //     new int[]{ -81, 100 },new int[]{ -11, 46 },new int[]{ -21, -38 },new int[]{ -30, -41 },new int[]{ 86, 18 },new int[]{ -68, 6 },
        //     new int[]{ 80, 75 },new int[]{ -96, -44 },new int[]{ -19, 66 },new int[]{ 21, 84 },new int[]{ -56, -64 },new int[]{ 39, -15 },
        //     new int[]{ 0, 45 },new int[]{ -81, -54 },new int[]{ -66, -93 },new int[]{ -4, 2 },new int[]{ -42, -67 },new int[]{ -15, -33 },
        //     new int[]{ 1, -32 },new int[]{ -74, -24 },new int[]{ 7, 18 },new int[]{ -62, 84 },new int[]{ 19, 61 },new int[]{ 39, 79 },
        //     new int[]{ 60, -98 },new int[]{ -76, 45 },new int[]{ 58, -98 },new int[]{ 33, 26 },new int[]{ -74, -95 },new int[]{ 22, 30 },
        //     new int[]{ -68, -62 },new int[]{ -59, 4 },new int[]{ -62, 35 },new int[]{ -78, 80 },new int[]{ -82, 54 },new int[]{ -42, 81 },
        //     new int[]{ 56, -15 },new int[]{ 32, -19 },new int[]{ 34, 93 },new int[]{ 57, -100 },new int[]{ -1, -87 },new int[]{ 68, -26 },
        //     new int[]{ 18, 86 },new int[]{ -55, -19 },new int[]{ -68, -99 },new int[]{ -9, 47 },new int[]{ 24, 94 },new int[]{ 92, 97 },
        //     new int[]{ 5, 67 },new int[]{ 97, -71 },new int[]{ 63, -57 },new int[]{ -52, -14 },new int[]{ -86, -78 },new int[]{ -17, 92 },
        //     new int[]{ -61, -83 },new int[]{ -84, -10 },new int[]{ 20, 13 },new int[]{ -68, -47 },new int[]{ 7, 28 },new int[]{ 66, 89 },
        //     new int[]{ -41, -17 },new int[]{ -14, -46 },new int[]{ -72, -91 },new int[]{ 4, 52 },new int[]{ -17, -59 },
        //     new int[]{ -85, -46 },new int[]{ -94, -23 },new int[]{ -48, -3 },new int[]{ -64, -37 },
        //     new int[]{ 2, 26 },new int[]{ 76, 88 },new int[]{ -8, -46 },new int[]{ -19, -68 }
        //      });
        // RobotSim(new int[] { 4, -1, 3 }, new int[][] { new int[] { } });
        // RobotSim(new int[] { 4, -1, 4, -2, 4 }, new int[][] { new int[] { 2, 4 } });
        // RobotSim(new int[] { -2, -1, 8, 9, 6 }, new int[][] {
        //     new int[] { -1, -3 },
        //     new int[] { 0, 1 },
        //     new int[] { -1, 5 },
        //     new int[] { -2, -4 },
        //     new int[] { 5, 4 },
        //     new int[] { -2, -3 },
        //     new int[] { 5, -1 },
        //     new int[] { 1, -1 },
        //     new int[] { 5, 5 },
        //     new int[] { 5, 2 } });
        // RobotSim(new int[] { 6, 9, -2, -1, -2 }, new int[][] {
        //     new int[] { -1, -3 },
        //     new int[] { 1, 1 },
        //     new int[] { -1, 5 },
        //     new int[] { 3, 4 },
        //     new int[] { 3, 4 },
        //     new int[] { -5, -4 },
        //     new int[] { 5, -4 },
        //     new int[] { 3, 5 },
        //     new int[] { -5, -2 },
        //     new int[] { -4, -2 } });
        //
        // RobotSim(new int[] { -2, -1, -2, 3, 7 }, new int[][] {
        //     new int[] { 1, -3 },
        //     new int[] { 2, -3 },
        //     new int[] { 4, 0 },
        //     new int[] { -2, 5 },
        //     new int[] { -5, 2 },
        //     new int[] { 0, 0 },
        //     new int[] { 4, -4 },
        //     new int[] { -2, -5 },
        //     new int[] { -1, -2 },
        //     new int[] { 0, 2 } });
        //100
        // }

        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int x, y;
            int max = 0;
            x = 0;
            y = 0;
            int heading;//1left,2up,3right,4down
            heading = 2;
            Dictionary<int, HashSet<int>> row = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> col = new Dictionary<int, HashSet<int>>();
            HashSet<int> tmp;
            for (int i = 0; i < obstacles.Length; i++)
            {
                if (obstacles[i].Length <= 1) continue;
                if (col.ContainsKey(obstacles[i][0]))
                {
                    if (!col[obstacles[i][0]].Contains(obstacles[i][1]))
                        col[obstacles[i][0]].Add(obstacles[i][1]);
                }
                else
                {
                    tmp = new HashSet<int>();
                    tmp.Add(obstacles[i][1]);
                    col.Add(obstacles[i][0], tmp);
                }
                if (row.ContainsKey(obstacles[i][1]))
                {
                    if (!row[obstacles[i][1]].Contains(obstacles[i][0]))
                        row[obstacles[i][1]].Add(obstacles[i][0]);
                }
                else
                {
                    tmp = new HashSet<int>();
                    tmp.Add(obstacles[i][0]);
                    row.Add(obstacles[i][1], tmp);
                }
            }
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == -2) { heading--; if (heading < 1) heading = 4; continue; }
                if (commands[i] == -1) { heading++; if (heading > 4) heading = 1; continue; }
                switch (heading)
                {
                    case 1:
                        if (!row.ContainsKey(y))
                        {
                            x -= commands[i];
                            break;
                        }
                        tmp = row[y];
                        for (int j = 0; j < commands[i]; j++)
                        {
                            if (tmp.Contains(x - 1))
                                break;
                            else
                                x--;
                        }
                        break;
                    case 2:
                        if (!col.ContainsKey(x))
                        {
                            y += commands[i];
                            break;
                        }
                        tmp = col[x];
                        for (int j = 0; j < commands[i]; j++)
                        {
                            if (tmp.Contains(y + 1))
                                break;
                            else
                                y++;
                        }
                        break;
                    case 3:
                        if (!row.ContainsKey(y))
                        {
                            x += commands[i];
                            break;
                        }
                        tmp = row[y];
                        for (int j = 0; j < commands[i]; j++)
                        {
                            if (tmp.Contains(x + 1))
                                break;
                            else
                                x++;
                        }
                        break;
                    case 4:
                        if (!col.ContainsKey(x))
                        {
                            y -= commands[i];
                            break;
                        }
                        tmp = col[x];
                        for (int j = 0; j < commands[i]; j++)
                        {
                            if (tmp.Contains(y - 1))
                                break;
                            else
                                y--;
                        }
                        break;
                }

                var maxTmp = (int)(Math.Pow(x, 2) + Math.Pow(y, 2));
                max = Math.Max(max, maxTmp);
            }
            // Console.WriteLine($"{x}  {y}");
            return max;
        }
    }
    // @lc code=end
}
