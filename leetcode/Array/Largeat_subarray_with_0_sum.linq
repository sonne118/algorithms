<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

class GfG
{
	int maxLen(int[] arr, int n)
	{
		int sum = 0, len = 0;
		Dictionary<int, int> map = new Dictionary<int,int>();
		for (int i = 0; i < n; i++)
		{
			sum += arr[i];
			if (sum == 0)
			{
				len = i + 1;
			}
			else if (map.ContainsKey(sum))
			{
				len = Math.Max(len, i - map[sum]);
			}
			else
			{
				map.Add(sum, i);
			}
		}
		return len;
	}
} // TC: O(n), SC: O(n)