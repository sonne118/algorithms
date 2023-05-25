<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

// Definition for singly-linked list.
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}


class Solution
{
	public ListNode reverseList1(ListNode head)
	{
		ListNode prev = null;
		ListNode curr = head;
		ListNode tmp = null;
		while (curr != null)
		{
			tmp = curr.next;
			curr.next = prev;
			prev = curr;
			curr = tmp;
		}
		return prev;
	}


	public ListNode reverseList(ListNode head)
	{
		if (head == null)
		{
			return null;
		}
		else if (head.next == null)
		{
			return head;
		}
		else
		{
			ListNode nextNode = head.next;
			head.next = null;
			ListNode rest = reverseList(nextNode);
			nextNode.next = head; //Head every time another
			return rest;
		}
	}

}

