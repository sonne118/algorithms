<Query Kind="Program" />

void Main()
{
	int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4};
	Console.WriteLine(Intersection(nums1,nums2)	);
}

public int[] Intersection(int[] nums1, int[] nums2)
{
	var h1 = new HashSet<int>(nums1);
    var h2 = new HashSet<int>(nums2);
	 h1.IntersectWith(h2);
	return h1.ToArray();
}