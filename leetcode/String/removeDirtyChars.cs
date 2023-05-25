using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    static int[] getCharCountArray(String str)
    {
        int[] count = new int[256];
        for (int i = 0; i < str.Length; i++)
            count[str[i]]++;

        return count;
    }

    public static void Function(string[] str)
    {
        int k = 0, j = 0;
        int[] count = getCharCountArray(str[1]);
        var n = str[0].Length;
        var arr = str[0].ToCharArray();

        while (k != str[0].Length)
        {
            var temp = arr[k];
            if (count[temp] == 0)
            {
                arr[j] = arr[k];
                j++;
            }
            else
                arr[k] = '\0';

            k++;
        }
        Console.WriteLine(new String(arr).Substring(0, j));
    }
}
}
