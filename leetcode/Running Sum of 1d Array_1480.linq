<Query Kind="Program" />

void Main()
{
int [] 	nums = {1, 2, 3, 4};
Console.WriteLine(RunningSum(nums));
}

public int[] RunningSum(int[] nums)
{
	int sum = 0;
    for (int i = 0; i < nums.Length; i++)
	{
		sum+=nums[i];
		nums[i] = sum;		
	}	
	return nums;
}