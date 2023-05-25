<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>


public static void Main()
{
	int[] arr = { 10, 5, 2, 7, 1, 9 };
	int n = arr.Length;
	int k = 15;
	Console.WriteLine("Length = " +
					   lenOfLongSubarr(arr, n, k));
}

// function to find the length of longest
// subarray having sum k
static int lenOfLongSubarr(int[] arr,
						   int n, int k)
{
	// HashMap to store (sum, index) tuples
	Dictionary<int,
			   int> map = new Dictionary<int,
										 int>();
	int sum = 0, maxLen = 0;

	// traverse the given array
	for (int i = 0; i < n; i++)
	{
		// accumulate sum
		sum += arr[i];

		// when subarray starts from index '0'
		if (sum == k)
			maxLen = i + 1;

		// make an entry for 'sum' if it is
		// not present in 'map'
		if (!map.ContainsKey(sum))
		{
			map.Add(sum, i);
		}
		// check if 'sum-k' is present in 'map'
		// or not
		if (map.ContainsKey(sum - k))
		{

			// update maxLength
			if (maxLen < (i - map[sum - k]))
				maxLen = i - map[sum - k];
		}
	}

	return maxLen;
}


// This code is contributed by PrinciRaj1992