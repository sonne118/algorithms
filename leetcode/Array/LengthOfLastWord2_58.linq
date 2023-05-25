<Query Kind="Expression">
  <Output>DataGrids</Output>
</Query>

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
		if (!String.IsNullOrEmpty(i))
			yield return i;
	}
}

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.