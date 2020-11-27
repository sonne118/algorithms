using System;

public class GetMajorityElement
{
    public static int GetMajorityElement(params int[] x)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int majority = x.Length / 2;
       
        foreach (int i in x)
            if (d.ContainsKey(i))
            {
                d[i]++;               
                if (d[i] > majority)
                    return i;
            }
            else
                d.Add(i, 1);      
        throw new Exception("No majority in array");
    }
}
