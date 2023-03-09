<Query Kind="Program" />

void Main()
{
 string s = "a ";
 Console.WriteLine(LengthOfLastWord(s));
}

public int LengthOfLastWord(string s)
{
	var h = s.Split(' ').ToHashSet();
	var c = isNotEmpty(h).Last();
	return c.Length;
}

public IEnumerable<string> isNotEmpty(ISet<string> set)
{
	foreach (var i in set)
	{
		if(!String.IsNullOrEmpty(i))
		yield return i;
	}		
}