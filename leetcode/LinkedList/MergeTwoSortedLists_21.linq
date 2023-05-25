<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>



 // Definition for singly-linked list.
 public class ListNode {
    public  int val;
    public  ListNode next;
    public  ListNode(int x) { val = x; }
  }
 
class Solution
{
	public ListNode mergeTwoLists1(ListNode l1, ListNode l2) //recurcive
	{
		if (l1 == null) return l2;
		if (l2 == null) return l1;

		if (l1.val <= l2.val)
		{
			l1.next = mergeTwoLists(l1.next, l2);
			return l1;
		}
		else
		{
			l2.next = mergeTwoLists(l1, l2.next);
			return l2;
		}
	}



	public ListNode mergeTwoLists(ListNode l1, ListNode l2) //iterative
	{
		ListNode newList = new ListNode(0);
		ListNode head = newList;
		while (l1 != null && l2 != null)
		{
			if (l1.val <= l2.val)
			{
				head.next = new ListNode(l1.val);
				l1 = l1.next;
			}
			else
			{
				head.next = new ListNode(l2.val);
				l2 = l2.next;
			}
			head = head.next;
		}
		if (l1 == null && l2 != null)
		{
			head.next = l2;
		}
		if (l2 == null && l1 != null)
		{
			head.next = l1;
		}
		return newList.next;
	}
}
