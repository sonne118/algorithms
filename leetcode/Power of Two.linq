<Query Kind="Expression" />

public bool IsPowerOfTwo(int n)
{
	{
		if (n == 0) return false;
		long x = n;
		return (x & -x) == x;
	}
}