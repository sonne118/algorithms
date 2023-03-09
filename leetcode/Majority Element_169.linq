<Query Kind="Program" />

void Main()
{
	int[]  nums = {2, 2, 1, 1, 1, 2, 2};
	Console.WriteLine(MajorityElement(nums));
}

public int MajorityElement(int[] nums)
{
	var d = new Dictionary<int, int>();
	
	foreach (var i in nums)
	{
		if (d.ContainsKey(i))
		{
			d[i]++;
			if(d[i]> nums.Length/2)
			return i;						
		}
		else
		d.Add(i,1);		
	}	
	return d.FirstOrDefault(v=> v.Value== d.Values.Max()).Key;
}