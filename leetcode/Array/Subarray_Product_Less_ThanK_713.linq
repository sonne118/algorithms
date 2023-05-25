<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

 int numSubarrayProductLessThanK(int[] nums, int k)
{
	int res = 0;
	int start = 0;
	int prod = 1;

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] >= k)
		{
			start = i + 1;
			prod = 1;
		}
		else
		{
			prod *= nums[i];
			while (prod >= k)
			{
				prod /= nums[start];
				start++;
			}
			res += i - start + 1;
		}
	}
	return res;
}

class Solution
{
	public int NumSubarrayProductLessThanK3(int[] nums, int k)
	{
		if (k <= 1) return 0; // nums = [1], k = 1
		int count = 0;
		int left = 0;
		int prod = 1;
		for (int i = 0; i < nums.Length; i++)
		{
			prod *= nums[i];
			while (prod >= k)
			{
				prod /= nums[left++];
			}
			count += i - left + 1;
		}
		return count;
	}
}


 int numSubarrayProductLessThanK2(int[] nums, int k)
{
	int n = nums.length;
	int res = 0;
	for (int i = 0; i < n; i++)
	{
		long t = 1;
		for (int j = i; j < n; j++)
		{
			t *= nums[j];
			if (t < k)
			{
				res++;
			}
			else break;
		}
	}
	return res;
}


//Input: nums = [10, 5, 2, 6], k = 100
//Output: 8
//Explanation: The 8 subarrays that have product less than 100 are:
//[10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6]
//Note that[10, 5, 2] is not included as the product of 100 is not strictly less than k.