using System;

public class SubarrayWithGivenSum
{
    public static int[] SubarrayWithGivenSum(int[] sub, int[] arr)
    {
        int sum = 0; int count = arr[0]; int nn = 1;
        int[] arrr = Array.Empty<int>();
        List<int> ls = new List<int>();

        for (int k = 0; k < count; k++)
        {
            for (int n = 0; n < arr[nn]; n++)
            {
                for (int i = n; i < arr.Length; i++)
                {
                    sum += arr[i];
                    if (sum == sub[1])
                    {
                        arrr = new int[2] { n, i };
                        break;
                    }
                }
                sum = 0;
                if (arrr.Length > 0)
                    break;
            }
            nn += 2;
        }
        return arrr;
    }
}
}
