<Query Kind="Expression">
  <Output>DataGrids</Output>
</Query>

public int SubarraySum(int[] nums, int k)
{
	var dict = new Dictionary<int, int>();
	dict.Add(0, 1);

	int ret = 0, sum = 0;
	foreach (var n in nums)
	{
		sum += n;
		if (dict.ContainsKey(sum - k))
		{
			ret += dict[sum - k]; //take numbers of array from dictionary
		}

		if (!dict.ContainsKey(sum))
		{
			dict.Add(sum, 0); // add subarray as sum in key

		}

		dict[sum]++; // increment value 
	}

	return ret;
}

//Input: nums = [1, 1, 1], k = 2
//Output: 2

class GFG
{

	static void Main()
	{
		int[] arr = { 10, 2, -2, -20, 10 };
		int k = -10;
		int n = arr.Length;
		int res = 0;

		// Calculate all subarrays
		for (int i = 0; i < n; i++)
		{
			int sum = 0;
			for (int j = i; j < n; j++)
			{

				// Calculate required sum
				sum += arr[j];

				// Check if sum is equal to
				// required sum
				if (sum == k)
					res++;
			}
		}
		Console.WriteLine(res);
	}
}