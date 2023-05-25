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
		if(sb.Length > 0 && sb[sb.Length-1] ==item)  //// check  adjacent and equal letters
		sb.Remove(sb.Length-1, 1);// simply remove adjust letter
		else
		sb.Append(item);  // add to string builder				
	}
	
	return sb.ToString();
	

}

//Input: s = "abbaca"
//Output: "ca"
//Explanation:
//For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".