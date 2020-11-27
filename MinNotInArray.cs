using System;

public class MinNotInArray
{
    public static int MinNotInArray(int[] array)
    {
        Array.Sort(array);
        var array2 = RemoveDublicate(array.ToList()).ToArray();
        for (int i = 0; i < array2.Length; i++)
            if (i + 1 != array2[i])
                return i + 1;
        return array2.Length + 1;
    }

    static public List<int> RemoveDublicate(List<int> list)
    {
        list.Sort();
        int cur = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (cur == list[i])
            {
                list.RemoveAt(i);
                i--;
            }
            else
                cur = list[i];
        }
        return list;
    }
}
