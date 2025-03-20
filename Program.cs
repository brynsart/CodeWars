using System;
using System.Collections.Generic;

public class MinimumRookDistance
{
    public static int CalculateMinRookDistance(int[][] pawns, int[] rook)
    {
        int totalDistance = 0;
        //Console.WriteLine(string.Join(",",pawnslist[1]));
        // Convert pawnsList to a List for easier manipulation (optional, based on your needs)
        List<int[]> pawnslist = new List<int[]>(pawns);
        //pawnslist = pawnslist.ToList();
        while (pawnslist.Count > 0)
        {
            int minDistance = int.MaxValue;
            int minPawnIndex = -1;

            for (int j = 0; j < pawnslist.Count; j++)
            {
                //Console.WriteLine(string.Join(",",pawnarray)); 
                int pawnX = pawnslist[j][0];
                int pawnY = pawnslist[j][1];
                int distanceX = Math.Abs(pawnX - rook[0]);
                int distanceY = Math.Abs(pawnY - rook[1]);
                int totalPawnDistance = distanceX + distanceY;
                if (totalPawnDistance < minDistance)
                {
                    minDistance = totalPawnDistance;
                    minPawnIndex = j;
                }
            }
            rook = pawnslist[minPawnIndex];
            pawnslist.RemoveAt(minPawnIndex);
            totalDistance += minDistance;
        }

        return totalDistance;
    }
}