using System;

public class longestUniqueSubsttr
{
    public static void longestUniqueSubsttr(string str)
    {
        var d = new SortedList<int, string>(); var h = new HashSet<char>(); char[] chars = str.ToCharArray();
        StringBuilder s = new StringBuilder();

        for (int i = 0; i < chars.Length; i++)
        {
            if (!h.Contains(chars[i]))
            {
                s.Append(chars[i]);
                h.Add(chars[i]);
            }
            else
            {
                if (!d.ContainsKey(s.Length))
                {
                    d.Add(s.Length, s.ToString());
                }
                s.Clear();
                h.Clear();
            }
        }
        if (d.Count != 0)
            Console.WriteLine(d.Keys.Last());
        else
            Console.WriteLine(0);
    }
}
