<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var nums = new int[] {1, 2, 3, 4};
	ProductExceptSelf(nums).Dump();
}
	public int[] ProductExceptSelf(int[] nums)
	{
		int[] returnValue = new int[nums.Length];
	
		int product = 1;
		for (int i = 0; i < nums.Length; i++)
		{
			product *= nums[i];
			returnValue[i] = product;
		}
	
		product = 1;
		for (int i = nums.Length - 1; i >= 0; i--) // go from the end and canceling value in current i
		                                           // take value from previous 
		{
			returnValue[i] = product * (i == 0 ? 1 : returnValue[i - 1]); //product * previous values
			product *= nums[i];
		}
	
		return returnValue;
	}
	
	//Input: nums = [1, 2, 3, 4]
	//Output: [24,12,8,6]
	
	//	public int[] ProductExceptSelf1(int[] nums)
	//	{
	//		int left = 1;
	//		int right = 1;
	//		int[] product = new int[nums.Length];
	//
	//		for (int i = 0; i < nums.Length; i++)
	//		{
	//			product[i] = left;
	//			left *= nums[i];
	//		}
	//
	//		for (int i = nums.Length - 1; i > -1; i--)
	//		{
	//			product[i] = right * product[i];  // left * right
	//			right *= nums[i];
	//		}
	//		return product;
	//	}
	//


// You can define other methods, fields, classes and namespaces here