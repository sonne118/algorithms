<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
 SequentialDigits1(1000,13000).Dump();	
}


public IList<int> SequentialDigits1(int low, int high)
{
	string sample = "123456789";
	int lowLength = low.ToString().Length;
	int highLength = high.ToString().Length;
	IList<int> result = new List<int>();
	//***
	//*** Iterate through all numbers between low length and high length
	//***
	for (int i = lowLength; i <= highLength; i++)
	{
		for (int j = 0; j <= sample.Length - i; j++)
		{
			var num = Convert.ToInt32(sample.Substring(j, i));
			if (num >= low && num <= high)
			{
				result.Add(num);
			}
		}
	}

	return result;
}



