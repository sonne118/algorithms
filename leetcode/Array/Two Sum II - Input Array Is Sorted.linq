<Query Kind="Program" />

void Main()
{

	//int[] numbers = { -1, 0 }; int target = -1;

	int[] numbers = {2, 7, 11, 15}; int target = 9;;
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


//Input: numbers = [2, 7, 11, 15], target = 9
//Output: [1,2]
//Explanation: The sum of 2 and 7 is 9.Therefore, index1 = 1, index2 = 2.We return [1, 2].