using System;

public class Triplets
{
    static int[] Triplets(int k, List<List<int>> ls)
    {
        int[] arr = new int[k]; int sum = 0; List<int> list = null;

        for (int j = 0; j < arr.Length; j++)
        {
            list = ls[j];
            for (int l = 0; l < list.Count; l++)
            {
                for (int p = 0; p < list.Count; p++)
                {
                    if (l == p) continue;

                    for (int r = p + 1; r < list.Count; r++)
                    {
                        sum = list[p] + list[r];

                        if (list[l] == sum)
                        {
                            arr[j] += 1;
                        }
                    }

                }
            }
            if (arr[j] == 0)
                arr[j] = -1;
        }

        return arr;
    }
}
