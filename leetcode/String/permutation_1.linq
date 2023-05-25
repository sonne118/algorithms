<Query Kind="Program" />


void Main()
{
	String str = "abc";
	List<String> list = new List<string>();
	dfs(str, "", list);
	foreach (string s in list)
	{
		Console.WriteLine(s);
	}
}

	public static void dfs(string str, string perm, List<String> list)
	{
		if (str.Length == 0)
		{
			list.Add(perm);
		}
		for (int i = 0; i < str.Length; i++)
		{
			char ch = str.ElementAt(i); // current character
			String tmp = str.Substring(0, i)+ str.Substring(i + 1);
			//String tmp =  str.Substring(i + 1) + str.Substring(0, i);
			dfs(tmp, perm + ch, list);
		}
	}


