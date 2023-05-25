using System;

public class IsSequenceBroken
{
    public static bool IsSequenceBroken(this IEnumerable<int> sequence)
    {
        bool broken = false;

        if (sequence != null)
        {
            var sequenceAsList = sequence.ToList();

            if (sequenceAsList.Any())
            {
                int lastValue = sequence.First();

                broken = sequence.Any(value =>
                {
                    if ((value - lastValue) > 1)
                        return true;

                    lastValue = value;

                    return false;
                });
            }
        }

        return broken;
    }
}
