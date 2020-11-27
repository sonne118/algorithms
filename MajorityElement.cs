using System;

public class MajorityElement
{
    public static int MajorityElement(int[] sequence)
    {
        int majority = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            for (int m = i + 1; m < sequence.Length; m++)
            {
                if (sequence[i] == sequence[m])
                    majority++;
            }
        }
        return majority > 0 ? majority : -1;
    }
}
