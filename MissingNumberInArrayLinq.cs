using System;

public class MissingNumberInArrayLinq
{
    public static int MissingNumberInArrayLinq(int[] arr)
    {
        List<int> sequence = arr.ToList(); List<int> missing = new List<int>();
        int diff = 0; int miss = 0;

        sequence.Aggregate((seed, aggr) =>
        {
            diff = (aggr - seed) - 1;
            if (diff > 0)
            {
                missing.AddRange(Enumerable.Range((aggr - diff), diff));
                miss = seed + 1;
            }
            return aggr;
        });
        return miss;
    }
}
