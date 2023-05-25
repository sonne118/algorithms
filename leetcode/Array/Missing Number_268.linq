<Query Kind="Program" />

void Main()
{
	int[] nums = {  9, 6, 4, 2, 3, 5, 7, 0, 1};
	Console.WriteLine(MissingNumber(nums) );
}

public int MissingNumber(int[] nums)
{
	int result = 0;
	for (int i = 0; i < nums.Length; ++i)
		result += (i + 1) - nums[i];
	return result;
	//	var ls =nums.ToList();
//	ls.Sort();
//	int diff = 0;
//	for (int i = 0; i < nums.Length ; i++)
//	{
//		for (int j = i + 1; j < nums.Length; j++)
//		{
//			//			diff = (ls[j] - ls[i]);
//			//			if (diff == 1)
//			//				break;
//			//
//			//			else if (diff > 1)
//			//				return ls[i] + 1;
//
//			diff = (ls[j] - ls[i]) - 1;
//			if (diff == 0)
//				break;
//			else if (diff > 0)
//				return ls[i] + 1;
//		}
//	}	
//	return 0;
}


//Input: nums = [3, 0, 1]
//Output: 2
//Explanation: n = 3 since there are 3 numbers, so all numbers are in the range[0, 3]. 2 is the missing number in the range since it does not appear in nums.