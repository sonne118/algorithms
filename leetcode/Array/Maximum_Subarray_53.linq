<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { -2,1,-3,4,-1,2,1,-5,4 };	
	MaxSubArray(nums).Dump();
}

public int MaxSubArray(int[] nums)
{
	int returnValue = Int32.MinValue;

	if (nums != null && nums.Length > 0)
	{
		int temp = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] > temp + nums[i])// if current value nums[i] > then sum up temp 
			{
				temp = nums[i];
			}
			else
			{
				temp += nums[i]; //sum up values of array
			}
			returnValue = Math.Max(returnValue, temp);
		}
	}

	return returnValue;
}

//Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
//Output: 6
//Explanation: The subarray[4, -1, 2, 1] has the largest sum 6.