<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { 0, 1, 0, 3, 12 };
	moveZeroes(nums);
	nums.Dump();
	
}

public void  moveZeroes(int[] nums)
{
	int lastNonZeroFoundAt = 0;
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] != 0)  // only not null values
		{
			nums[lastNonZeroFoundAt] = nums[i]; //
			lastNonZeroFoundAt++;   //increment  index of not null  values
		}
	}
	for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
	{
		nums[i] = 0;
	}
}



//Input: nums = [0, 1, 0, 3, 12]
//Output: [1,3,12,0,0]