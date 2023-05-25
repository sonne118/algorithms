using System;

public class SequenceFindMissings
{
    //In this article, we  will learn different ways to find missing number in a sequence in C#.
    public static IEnumerable SequenceFindMissings(this IList<int> sequence)
    {
        var missing = new List<int>();

        if ((sequence != null) && (sequence.Any()))
        {
            sequence.Aggregate((seed, aggr) =>
            {
                var diff = (aggr - seed) - 1;

                if (diff > 0)
                    missing.AddRange(Enumerable.Range((aggr - diff), diff));

                return aggr;
            });
        }

        return missing;
    }
}
