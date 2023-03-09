<Query Kind="Program" />

void Main()
{

	int[] numbers = {-1,0}; int target = -1;
	Console.WriteLine(TwoSum(numbers, target));
	
}

public int[] TwoSum(int[] n, int target)
{
	for (int i = 0; i < n.Length-1; i++)
	{
		for (int j = i + 1; j < n.Length ; j++)
		{
			if(n[i] + n[j] == target)
				return new int[] {i+1,j+1};							
	}		
	}

	return Array.Empty<int>();
}