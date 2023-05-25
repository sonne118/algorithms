<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

// Definition for singly-linked list.
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode() { }
	public ListNode(int val) { this.val = val; }
	public ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

//Input: head = [1, 2, 3, 4, 5]
//Output: [1,5,2,4,3]

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
	public void reorderList(ListNode head)
	{
		if (head == null || head.next == null) return;
		ListNode slow = head, fast = head;   //add new two ListNodes
		while (fast.next != null && fast.next.next != null)
		{
			slow = slow.next; //fill it dates
			fast = fast.next.next; //fill it dates
		}
		ListNode head2 = slow.next;
		slow.next = null; // next is null now
		ListNode head1 = head;

		head2 = reverse(head2); // reverse head2   5,4,3,2,1
		ListNode curr = new ListNode(-1);
		while (head1 != null)
		{
			ListNode tmp = head1.next; // tmp is storing templolary Node It's 2
			curr.next = head1; //It's 1
			head1.next = head2;// head2 last Node in proper order(first and last [1,5])
			curr = head2;   // now curr is first iten from head2 It's 5
			head1 = tmp;  //open next "pair" data from 2 value
			if (head2 != null) head2 = head2.next;
		}
		 //head1 1-> 2 ->3
		 //head2 5-> 4 //reversing
		//[1,5,2,4,3]
	}
} // TC: O(n), SC: O(1)