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
	public ListNode reverse(ListNode head)
	{
		ListNode prev = null;
		ListNode curr = head;
		while (curr != null)
		{
			ListNode tmp = curr.next;
			curr.next = prev;
			prev = curr;
			curr = tmp;
		}
		return prev;
	}
	public bool isPalindrome(ListNode head)
	{
		if (head == null) return true;
		if (head.next == null) return true;
		if (head.next.next == null) return head.val == head.next.val;
		ListNode slow = head, fast = head;
		while (fast.next != null && fast.next.next != null)
		{
			slow = slow.next;
			fast = fast.next.next;
		}
		ListNode head1 = head, head2 = slow.next;
		slow.next = null;
		head2 = reverse(head2);
		while (head2 != null)
		{
			if (head1.val != head2.val)
			{
				return false;
			}
			head1 = head1.next;
			head2 = head2.next;
		}
		return true;
	}
}