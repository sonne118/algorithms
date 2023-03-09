<Query Kind="Program" />

void Main()
{
	 string s = "abbaca";
	 Console.WriteLine(RemoveDuplicates(s));
}

public string RemoveDuplicates(string s)
{
	var sb = new StringBuilder();
	foreach (var item in s)
	{
		if(sb.Length > 0 && sb[sb.Length-1] ==item)
		sb.Remove(sb.Length-1, 1);
		else
		sb.Append(item);				
	}
	
	return sb.ToString();
	

}