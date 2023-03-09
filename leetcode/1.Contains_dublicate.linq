<Query Kind="Program" />

void Main()
{
	int [] arr = {1,2,3};
	bool isTrue = ContainsDuplicate(arr);
	Console.WriteLine(isTrue);
}

public bool ContainsDuplicate(int[] nums)
{
	var set = new HashSet<int>();
	for (int i = 0; i < nums.Length; i++)
	{
		if (!set.Contains(nums[i]))
		{
			set.Add(nums[i]);
		}
		else 
		{
			return true;
		}
	}	
   return false;
}

