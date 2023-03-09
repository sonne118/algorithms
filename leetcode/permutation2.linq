<Query Kind="Program" />

void Main()
{	
	string S= "absetab";		
	char[] arr = S.ToCharArray();						
    Array.Sort(arr);
    String str = new String(arr);	
    List<string> list = new List<string>();
	
	dfs(str, "", list);

	foreach (string s in list)
	{
		Console.WriteLine(s);
	}
}

static void dfs(String str, String perm, List<String> list)
	{
		if (str.Length == 0)
		{
			list.Add(perm);
		}
		HashSet<char> set = new HashSet<char>();
		for (int i = 0; i < str.Length; i++)
		{
			char ch = str.ElementAt(i);
			if (!set.Contains(ch))
			{
				String tmp = str.Substring(0, i) + str.Substring(i + 1);
				dfs(tmp, perm + ch, list);
			}
			set.Add(ch);
		}
	}
