<Query Kind="Program">
  <NuGetReference>NUnit</NuGetReference>
  <NuGetReference>NUnitLite</NuGetReference>
  <NuGetReference>xunit</NuGetReference>
  <Namespace>NUnit.Framework</Namespace>
</Query>


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

class Binary_Tree_Level_Order_Traversal
{
	public IList<IList<int>> LevelOrder(TreeNode root)
	{
		SortedDictionary<int, IList<int>> dict = new SortedDictionary<int, IList<int>>();
		Process(root, 0, dict);
		return dict.Select(x => x.Value).ToList();
	}

	private void Process(TreeNode node, int level, SortedDictionary<int, IList<int>> dict)
	{
		if (node != null)
		{
			Process(node.left, level + 1, dict);

			Process(node.right, level + 1, dict);

			if (dict.ContainsKey(level))
			{
				dict[level].Add(node.val);
			}
			else
			{
				dict.Add(level, new List<int>() { node.val });
			}
		}
	}

#region private::Tests
	[Test(Description = "https://leetcode.com/problems/binary-tree-level-order-traversal/")]
	[Category("Medium")]
	[Category("LeetCode")]
	[Category("Binary Tree Level Order Traversal")]
	[TestCaseSource("Input")]
	public void Test1((IList<IList<int>> Output, TreeNode Input) item)
	{
		var response = this.LevelOrder(item.Input);
		Assert.AreEqual(item.Output, response);
	}

	public static IEnumerable<(IList<IList<int>> Output, TreeNode Input)> Input
	{
		get
		{
			return new List<(IList<IList<int>> Output, TreeNode Input)>()
				{
					(new List<IList<int>>(){
					new List<int>(){ 3},
					new List<int>(){ 9,20},
					new List<int>(){ 15,7},
						}, new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))))
				};
		}
	}
	#endregion
}
