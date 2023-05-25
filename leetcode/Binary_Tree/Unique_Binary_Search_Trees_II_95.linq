<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

class Unique_Binary_Search_Trees_II
{
	public IList<TreeNode> GenerateTrees(int n)
	{
		if (n == 0)
		{
			return new List<TreeNode>();
		}

		return DFS(1, n);
	}

	private IList<TreeNode> DFS(int start, int end)
	{
		//***
		//*** Return list with null if start is greater than end
		//***
		if (start > end)
		{
			return new List<TreeNode>() { null };
		}
		var result = new List<TreeNode>();

		//***
		//*** iterate through all combinations between start and end
		//***
		for (int i = start; i <= end; i++)
		{
			//***
			//*** Building up list of nodes for left and right legs
			//***
			var leftList = DFS(start, i - 1);
			var rightList = DFS(i + 1, end);
			//***
			//*** Iterate through all combinations for right and left legs
			//*** And build up a new Tree Node
			//***
			foreach (var left in leftList)
			{
				foreach (var right in rightList)
				{
					var root = new TreeNode(i);
					root.left = left;
					root.right = right;
					result.Add(root);
				}
			}
		}

		return result;
	}

	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}

		public override string ToString()
		{
			return $"{this.val}";
		}
	}