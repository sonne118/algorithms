using System;

public class MissingNumberInArray
{
    public static int MissingNumberInArray(int[] arr)
    {
        int diff = 0;
        List<int> ls = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int p = i + 1; p < arr.Length; p++)
            {
                diff = (arr[p] - arr[i]) - 1;
                if (diff == 0)
                    break;
                else if (diff > 0)
                    return arr[i] + 1;
            }
        }
        return 0;
    }

    public static int MissingNumberInArrayLinq(int[] arr)
    {
        List<int> sequence = arr.ToList();
        int diff = 0;
        int miss = 0;
        List<int> missing = new List<int>();
        sequence.Aggregate((seed, aggr) =>
        {

            diff = (aggr - seed) - 1;
            if (diff > 0)
            {
                missing.AddRange(Enumerable.Range((aggr - diff), diff));
                miss = seed + 1;
            }
            return aggr;
        }
        );
        return miss;
    }
}
