<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { 1, 2, 3, 1}; int k = 3;
	ContainsNearbyDuplicate(nums,k).Dump();
	
}


public bool ContainsNearbyDuplicate(int[] nums, int k)
{
	var map = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)  // condition of ()i - map[nums[i]] <= k) two distinkt indexes
			return true;
		map[nums[i]] = i;  //add new item in map , nums[i] is key
	}

	return false;
}


//Input: nums = [1, 2, 3, 1], k = 3
//Output: true

// You can define other methods, fields, classes and namespaces here