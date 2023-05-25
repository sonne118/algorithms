<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { 3, 1, 4, 1, 5}; int  k = 2;
	FindPairs(nums, k).Dump();
}

public int FindPairs(int[] nums, int k)
{
	if (nums != null && nums.Length > 1)
	{
		Array.Sort(nums);

		IDictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (var item in nums)
		{
			dictionary.TryAdd(item, 0);
			dictionary[item]++;
		}

		int result = 0;
		foreach (var item in dictionary)
		{
			dictionary[item.Key]--;

			int valueRequired = item.Key + k;// add 1 +2 

			if (dictionary.ContainsKey(valueRequired)// looking for in dict
				&& dictionary[valueRequired] > 0)
			{
				result++;  //if it's true ++ result
			}
		}

		return result;
	}

	return 0;
}

//Input: nums = [3, 1, 4, 1, 5], k = 2
//Output: 2
//Explanation: There are two 2 - diff pairs in the array, (1, 3) and(3, 5).
//Although we have two 1s in the input, we should only return the number of unique pairs.