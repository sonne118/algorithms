<Query Kind="Expression">
  <Output>DataGrids</Output>
</Query>


public bool CanPlaceFlowers(int[] flowerbed, int n)
{
	if (flowerbed == null || flowerbed.Length == 0)
	{
		return false;
	}

	int len = flowerbed.Length;
	int count = 1;  // count the number of continous empty plots.
	int rst = 0;    // the total number of empty plots that coule be planted.
	for (int i = 0; i < len; i++)
	{
		if (flowerbed[i] == 0)
		{
			count++;
		}
		else
		{
			rst += (count - 1) / 2;
			count = 0;
		}
	}

	if (count != 0)
	{
		rst += count / 2;
	}

	return rst >= n;
}



public bool CanPlaceFlowers(int[] flowerbed, int n)
{
	var count = 0;
	for (int i = 0; i < flowerbed.Length; i++)
	{
		if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
		{                                   
			flowerbed[i++] = 1;
			count++;
		}

		if (count >= n) return true;
	}

	return count >= n;
}

//Input: flowerbed = [1, 0, 0, 0,        1], n = 1
//Output: true