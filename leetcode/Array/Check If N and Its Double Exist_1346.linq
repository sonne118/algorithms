<Query Kind="Program" />

void Main()
{

	int[] arr = {7,1,14,11};//{10,2,5,3};
    Console.WriteLine(CheckIfExist(arr));
}

public bool CheckIfExist(int[] arr)
{
  var h = arr;
  
 for (int i = 0; i < h.Length -1; i++)
{
		for (int j = i + 1; j < h.Length - 1; j++)
		{
			if(i != j && (0 <= i && j < h.Length )&& h[i] == 2 * h[j])
			return true;
						
		}
	}
	
 return false;
}



public bool CheckIfExist2(int[] arr)
{
	//Array.Sort(arr);
	for (int i = 0; i < arr.Length - 1; i++)
	{
		var doubleItem = arr[i] * 2;
		var divItem = arr[i] / 2;
		for (int j = i + 1; j < arr.Length; j++)
		{
			if (arr[j] == doubleItem || (arr[i] % 2 == 0 && arr[j] == divItem))
			{
				return true;
			}
		}
	}

	return false;
}

//i != j
//0 <= i, j < arr.length
//arr[i] == 2 * arr[j]