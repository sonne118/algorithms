<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode() { }
	public ListNode(int val) { this.val = val; }
	public ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}


public class Solution
{
	public bool hasCycle(ListNode head)
	{
		if (head == null || head.next == null)
		{
			return false;
		}
		ListNode p1 = head;
		ListNode p2 = head.next;
		while (p1 != p2)
		{
			if (p2 == null || p2.next == null)
			{
				return false;
			}
			p1 = p1.next; //check next Node
			p2 = p2.next.next; //check next next Node 
		}
		return true;
	}
}
