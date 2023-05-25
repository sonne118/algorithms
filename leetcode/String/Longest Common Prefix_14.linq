<Query Kind="Program" />

void Main()
{
	string[] strs = { "flower", "flow", "flight"};
	Console.WriteLine(LongestCommonPrefix(strs));
}


	public string LongestCommonPrefix(string[] strs)
	{
		if (strs.Length == 0) return "";
		string prefix = strs[0];   //take first word
		for (int i = 1; i < strs.Length; i++) // iterate arr words
			while (strs[i].IndexOf(prefix) != 0)  // check whethe prefix in words and iterate until will be true and prefix cut
			{
				prefix = prefix.Substring(0, prefix.Length - 1);
				if (String.IsNullOrEmpty(prefix)) return "";
			}
		return prefix;
	}

public String LongestCommonPrefix3(String[] strs)
{
	if (strs == null || strs.Length == 0) return "";
	String pre = strs[0];
	int i = 1;
	while (i < strs.Length)
	{
		while (strs[i].IndexOf(pre) != 0)
			pre = pre.Substring(0, pre.Length - 1);
		i++;
	}
	return pre;
}

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"

public string LongestCommonPrefix2(string[] strs)
{
	//***
	//*** check if array is null or empty
	//***
	if (strs == null || strs.Length == 0)
	{
		return "";
	}
	//***
	//*** If array length is 1, return the same text
	//***
	else if (strs.Length == 1)
	{
		return strs[0];
	}
	else
	{
		var frstStr = strs[0];
		int totalStrs = strs.Length;
		string returnValue = "";
		//***
		//*** Loop through all text of the first word
		//***
		for (var i = frstStr.Length; i >= 0; i--)
		{
			var text = frstStr.Substring(0, i);
			//***
			//*** check if all items in array starts with the text
			//***
			if (strs.Any(x => !x.StartsWith(text)))
			{

			}
			else
			{
				returnValue = text;
				break;
			}
		}

		return returnValue;
	}

}
    