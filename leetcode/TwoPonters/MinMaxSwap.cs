using System;

public class MinMaxSwap
{
    public static void MinMaxSwap(int[] x)
    {
        int min = 0;
        int max = 0;

        for (int i = 1; i < x.Length; i++)
        {
            if (x[min] > x[i])
                min = i;
            if (x[max] < x[i])
                max = i;
        }
        int temp = x[min];
        x[min] = x[max];
        x[max] = temp;
    }
}
