<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
	findDisappearedNumbers(nums).Dump();

}

//public IList<int> FindDisappearedNumbers(int[] nums)
//{
//	var recs = Enumerable.Range(1, nums.Length).Except(nums)//  use except linq
//		.ToList();
//
//	return recs;
//}

//Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
//Output: [5,6]



public List<int> findDisappearedNumbers(int[] nums)
{
	for (int i = 0; i < nums.Length; i++)
	{
		int index = Math.Abs(nums[i]);
		if (nums[index - 1] > 0)
		{
			nums[index - 1] *= -1;
		}
	}
	List<int> res = new List<int>();
	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] > 0)
		{
			res.Add(i + 1);
		}
	}
	return res;
}

//