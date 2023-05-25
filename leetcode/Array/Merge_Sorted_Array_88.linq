<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums1 = { 1, 2, 3, 0, 0, 0 }; int m = 3; int[] nums2 = { 2, 5, 6};  int n = 3;
	Merge(nums1, m, nums2, n);
}


	public void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		int num2Index = 0;
		for (int i = m; i < nums1.Length; i++)
		{
			nums1[i] = nums2[num2Index]; // add data to nums1 from index m so the end of the arr nums1
			num2Index++;
		}

		Array.Sort(nums1);
		nums1.Dump();
	}

//Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3
//Output: [1,2,2,3,5,6]
//Explanation: The arrays we are merging are[1, 2, 3] and[2, 5, 6].
//The result of the merge is [1, 2, 2, 3, 5, 6] with the underlined elements coming from nums1.

//public class Solution
//{
//	public void merge(int[] nums1, int m, int[] nums2, int n)
//	{
//		m--;
//		n--;
//		for (int i = m + n + 1; i >= 0; i--)
//		{
//			int a = m >= 0 ? nums1[m] : int.MinValue;
//			int b = n >= 0 ? nums2[n] : int.MinValue;
//			if (a > b)
//			{
//				nums1[i] = a;
//				m--;
//			}
//			else
//			{
//				nums1[i] = b;
//				n--;
//			}
//		}
//	}
//}
