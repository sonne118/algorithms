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
	public ListNode detectCycle(ListNode head)
	{
		ListNode slow = head;
		ListNode fast = head;
		ListNode start = null;
		while (fast != null && fast.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
			if (slow == fast)
			{
				start = head;
				while (start != slow)
				{
					start = start.next;
					slow = slow.next;
				}
				break;
			}
		}
		return start;
	}
}