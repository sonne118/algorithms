<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { 1, 2, 0};
	FirstMissingPositive(nums).Dump();
}

public int FirstMissingPositive(int[] nums)
{
	if (nums == null || nums.Length == 0)
	{
		return 1;
	}
	else
	{
		for (int i = 1; i <= Int32.MaxValue; i++)
		{
			if (!nums.Contains(i)) // go thought all number
			{
				return i;
			}
		}
		return Int32.MaxValue;
	}
}

//Input: nums = [1, 2, 0]
//Output: 3
//Explanation: The numbers in the range[1, 2] are all in the array.

// You can define other methods, fields, classes and namespaces here