using System;

public class FindDuplicate
{
    static public List<int> RemoveDublicate(List<int> list)
    {
        int cur = list[0];
        list.Sort();

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
