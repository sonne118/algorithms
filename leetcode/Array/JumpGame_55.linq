<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

class Solution
{
	public bool canJump(int[] nums)
	{
		for (int i = 1; i < nums.Length; i++)
		{
			bool canReach = false;
			for (int j = i - 1; j >= 0; j--)
			{
				if (i - j <= nums[j])
					canReach = true;
			}
			if (canReach == false)
				return false;
		}
		return true;
	}
}

//Input: nums = [2, 3, 1, 1, 4]
//Output: true
//Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

	 bool canJump(int[] nums)
	{
		int reachable = 0;
		for (int i = 0; i < nums.Length && i <= reachable; i++)
		{
			reachable = Math.Max(reachable, nums[i] + i);
			if (reachable >= nums.Length - 1)
				return true;
		}
		return false;
	}
