<Query Kind="Expression">
  <Output>DataGrids</Output>
</Query>

public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
{
	var arr = nums.Select((num, index) => new { num, index })
				  .OrderBy(u => u.num)
				  .ToArray();

	for (int i = 0; i < nums.Length; i++)
		for (int j = i + 1; j < nums.Length && arr[j].num - (long)arr[i].num <= t; j++)
			if (Math.Abs(arr[i].index - arr[j].index) <= k)
				return true;

	return false;
}