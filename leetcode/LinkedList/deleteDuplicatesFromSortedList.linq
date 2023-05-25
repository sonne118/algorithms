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
 
class Solution
{
	public ListNode deleteDuplicates(ListNode head)
	{
		ListNode dummyHead = new ListNode(-1);
		dummyHead.next = head;
		ListNode prev = dummyHead;
		while (head != null)
		{
			if (head.next != null && head.val == head.next.val)
			{
				while (head.next != null && head.val == head.next.val)
				{
					head = head.next;
				}
				prev.next = head;
				prev = head;
			}
			else
			{
				prev = prev.next;
			}
			head = head.next;
		}
		return dummyHead.next;
	}
}