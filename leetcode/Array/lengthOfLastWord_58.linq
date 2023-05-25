<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>


void Main()
{
	string s = "Hello World";
	lengthOfLastWord(s).Dump();
}

public int lengthOfLastWord(String s)
{
	int count = 0;
	// We are looking for the last word so let's go backward
	for (int i = s.Length - 1; i >= 0; i--)
	{
		if (s.ElementAt(i) != ' ')
		{ // a letter is found so count
			count++;
		}
		else
		{  // it's a white space instead
		   //  Did we already started to count a word ? Yes so we found the last word
			if (count > 0) return count;
		}
	}
	return count;
}

