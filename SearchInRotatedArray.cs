using System;

public class SearchInRotatedArray
{
    public static int SearchInRotatedArray(List<int> sequence, int k)
    {
        int diff = 0; int found = 0;
        sequence.Aggregate((seed, aggr) =>
        {

            diff = aggr - seed;
            if (diff > 1)
                found = -1;

            return aggr;
        });

        if (found == 0)
        {
            return sequence.IndexOf(k);
        }

        return found;
    }
}
