<Query Kind="Program" />

void Main()
{
	
string	s = "Let's take LeetCode contest";

Console.WriteLine(ReverseWords(s));
	
}

public string ReverseWords(string s)
{
	var list = s.Split(' ').ToList();
	
	var  sb = new StringBuilder();
	
	foreach (var item in list)
	{
	 sb.Append(item.Reverse().ToArray());		
	 sb.Append(' ');
	}
	
	return sb.ToString().TrimEnd();

}

//Input: s = "Let's take LeetCode contest"
//Output: "s'teL ekat edoCteeL tsetnoc"