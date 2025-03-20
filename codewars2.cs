using System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
    public static int Solution(int value)
    {
        List<int> div3 = new List<int>();
        List<int> div5 = new List<int>();
        int i = 1;
        int sum = 0;

        if (value > 0)
        {
            while (true)
            {
                if (3 * i >= value)
                {
                    break;
                }
                div3.Add(3 * i);
                i++;
            }
            i = 0;
            while (true)
            {
                if (5 * i >= value)
                {
                    break;
                }
                if (!div3.Contains(5 * i))
                {
                    div5.Add(5 * i); // So div by 3 and 5 not counted twice
                }
                i++;
            }
            sum = div3.Sum() + div5.Sum();
            return sum;
        }
        else
        {
            return 0;
        }
    }
}