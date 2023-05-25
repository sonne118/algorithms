<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 }; int k = 3;
	rotate(nums, k);

}
public void rotate(int[] nums, int k)
{
	int[] temp = new int[nums.Length];
	for (int i = 0; i < nums.Length; i++)
	{
		temp[(i + k) % nums.Length] = nums[i];  // where can start enumerate array // here is shift of  start index ((i + k) % nums.Length)
		                                        // [0,0,0,1,2,3,4]
	}
	for (int i = 0; i < nums.Length; i++)
	{
		nums[i] = temp[i];		
	}

    temp.Dump();
	return;
}
//Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
	//Output: [5,6,7,1,2,3,4]
	//Explanation:
	//rotate 1 steps to the right: [7,1,2,3,4,5,6]
	//rotate 2 steps to the right: [6,7,1,2,3,4,5]
	//rotate 3 steps to the right: [5,6,7,1,2,3,4]
	
	//idx:     0  1  2  3  4  5  6                   7  8   9  10 11 12 13
	//old array: [] [] [] [] [] [] [7] -> new array: [] [] [7] [] [] [] []
	
	//class Solution
	//{
	//	public int rob(int[] nums)
	//	{
	//		if (nums.Length == 1) return nums[0];
	//		return Math.Max(rob(nums, 0, nums.Length - 1), rob(nums, 1, nums.Length));
	//	}
	//	private int rob(int[] nums, int start, int end)
	//	{
	//		int max = 0;
	//		int p1 = 0;
	//		int p2 = 0;
	//		for (int i = start; i < end; i++)
	//		{
	//			max = Math.Max(p2 + nums[i], p1);
	//			p2 = p1;
	//			p1 = max;
	//		}
	//		return max;
	//	}
	//}


// You can define other methods, fields, classes and namespaces here