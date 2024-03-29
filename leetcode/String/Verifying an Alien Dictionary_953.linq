<Query Kind="Program" />

void Main()
{
	string[] words = { "hello", "leetcode"}; string order = "hlabcdefgijkmnopqrstuvwxyz";
	Console.WriteLine(IsAlienSorted(words,order));
}


public bool IsAlienSorted2(string[] words, string order)
{
	int index = 0;
	var dict = order.ToDictionary(x => index++, y => y);

	int[] val = new int[words.Length];

	words = words.OrderBy(x => x.Length).ToArray();

	for (int i = 0; i < words.Length; i++)
	{

	}

	return false; ;
}

public bool IsAlienSorted(string[] words, string order)
{ 
	int [] idx = getCharCountArray(order);
	bool skep = false;
	for (int i = 0; i < words.Length-1 ; i++)
	{
		var word1= words[i];
		var word2 = words[i + 1];
		skep = false;
		for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++)
		{
			if (word1[j] != word2[j])
			{
				if(idx[word1[j]-'a'] > idx[word2[j]-'a'])
				return false;
				skep= true;
				break;
			}
												
		}	
		if(skep)
		continue;

		if (word1.Length > word2.Length)
			return false;
	}				
	return 	true;
		
}

static int[] getCharCountArray(string order)
{
	int[] count = new int[26];
	for (int i = 0; i < order.Length; i++)
		count[order[i]-'a'] = i;

	return count;
}

//Input: words = ["hello", "leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
//Output: true
//Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.