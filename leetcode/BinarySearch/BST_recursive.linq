<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

public int Binsearch(int [] a, int x, int low, int high)
{
	int mid;
	if (low > high)
		return -1;
	mid = (low + high) / 2;
	if (x == a[mid])
	{
		return (mid);
	}
	else
	if (x < a[mid])
	{
		Binsearch(a, x, low, mid - 1);
	}
	else
	{
		Binsearch(a, x, mid + 1, high);
	}
}