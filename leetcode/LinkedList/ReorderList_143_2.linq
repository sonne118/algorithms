<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

public class Reorder_List
{
	public void ReorderList(ListNode head)
	{
		if (head != null)
		{
			List<ListNode> nums = new List<ListNode>();
			var node = head;
			while (true)
			{
				if (node != null)
				{
					nums.Add(node); //creating List<ListNode> with gaps (null)
					nums.Add(null);
					node = node.next;
				}
				else
				{
					break;
				}
			}
			nums.RemoveAt(nums.Count - 1);  //remove last ListNode exmpl( nums.Add(null)
			head = Update(head, nums, nums.Count + 1, 0);
		}
	}

	private ListNode Update(ListNode node, List<ListNode> nodes, int maxCount, int i)
	{
		if (maxCount > 0)
		{
			node = nodes[i];
			node.next = nodes[nodes.Count - 1 - i];
			node.next.next = Update(node.next.next, nodes, maxCount - 4, i += 2);
		}
		else
		{
			node = null;
		}

		return node;
	}
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}

	public override string ToString()
	{
		return $"{this.val}";
	}
}