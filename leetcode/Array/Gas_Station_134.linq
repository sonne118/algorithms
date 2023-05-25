<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	string s = "Hello World";

	int[] gas = { 1, 2, 3, 4, 5 }, cost = { 3, 4, 5, 1, 2};
	CanCompleteCircuit(gas, cost).Dump();
}

public int CanCompleteCircuit(int[] gas, int[] cost)
{
	if (gas.Sum() >= cost.Sum())
	{
		int returnValue = 0;
		int total = 0;
		for (int i = 0; i < gas.Length; i++)
		{
			total += gas[i] - cost[i];
			if (total < 0)
			{
				total = 0;
				returnValue = i + 1;
			}
		}

		return returnValue;
	}
	else
	{
		return -1;
	}
}

//Input: gas = [1, 2, 3, 4, 5], cost = [3, 4, 5, 1, 2]
//Output: 3
//Explanation:
//Start at station 3(index 3) and fill up with 4 unit of gas.Your tank = 0 + 4 = 4
//Travel to station 4.Your tank = 4 - 1 + 5 = 8
//Travel to station 0.Your tank = 8 - 2 + 1 = 7
//Travel to station 1.Your tank = 7 - 3 + 2 = 6
//Travel to station 2.Your tank = 6 - 4 + 3 = 5
//Travel to station 3.The cost is 5.Your gas is just enough to travel back to station 3.
//Therefore, return 3 as the starting index.
//Given two integer arrays gas and cost, return the starting gas station's index if you can travel around
//the circuit once in the clockwise direction, otherwise return -1. If there exists a solution, it is guaranteed to be unique

//public int canCompleteCircuit(int[] gas, int[] cost)
//{
//	int pos = -1, curr = 0, total = 0;
//
//	for (int i = 0; i < gas.length; i++)
//	{
//		int diff = gas[i] - cost[i];
//
//		curr += diff;
//		total += diff;
//
//		if (curr < 0)
//		{
//			curr = 0;
//			pos = i;
//		}
//	}
//
//	if (total >= 0)
//	{
//		return pos + 1;
//	}
//
//	return -1;
//}


// You can define other methods, fields, classes and namespaces here