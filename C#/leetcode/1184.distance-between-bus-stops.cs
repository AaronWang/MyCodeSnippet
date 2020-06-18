using System;
using System.Net.Cache;
/*
 * @lc app=leetcode id=1184 lang=csharp
 *
 * [1184] Distance Between Bus Stops
 */
namespace DistanceBetweenBusStops
{
    // @lc code=start
    public class Solution
    {

        // [1,2,3,4]
        // 0
        // 3
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int totalStops = distance.Length;
            int distanceL, distanceR;
            distanceL = 0;
            distanceR = 0;
            int nextStopR = start;
            int nextStopL = start;
            bool reachDestinationR = false;
            bool reachDestinationL = false;
            do
            {
                if (reachDestinationR == false)
                {
                    distanceR += distance[nextStopR];
                    nextStopR = nextStopR + 1 > totalStops - 1 ? 0 : nextStopR + 1;
                }
                if (reachDestinationL == false)
                {
                    nextStopL = nextStopL - 1 < 0 ? totalStops - 1 : nextStopL - 1;
                    distanceL += distance[(nextStopL)];
                }
                if (nextStopR == destination)
                {
                    reachDestinationR = true;
                    if (distanceR < distanceL)
                        break;
                }
                if (nextStopL == destination)
                {
                    reachDestinationL = true;

                    if (distanceR > distanceL)
                        break;
                }
            } while (!(reachDestinationL && reachDestinationR));
            return Math.Min(distanceL, distanceR);
        }
    }
    // @lc code=end
}