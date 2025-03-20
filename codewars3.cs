using System;
public class NewAverage
{
    public static long NewAvg(double[] arr, double navg)
    {
        double total = 0;
        double intermediate;
        long donation;
        // your code
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        intermediate = navg * (arr.Length + 1);
        donation = (long)Math.Ceiling(intermediate - total);
        if (donation <= 0)
        {
            throw new ArgumentException("donation less than or equal to 0");
        }
        return donation;
    }
}