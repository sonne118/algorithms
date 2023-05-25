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
class Solution
{
	public ListNode deleteDuplicates(ListNode head)
	{
		if (head == null) return null;
		ListNode dummyHead = new ListNode(-1);
		dummyHead.next = head;
		ListNode curr = head, prev = dummyHead;  //head(ListNode) will be removing and dummyHead will be adding
		while (curr != null)
		{
			if (curr.next != null && curr.val == curr.next.val)
			{
				while (curr.next != null && curr.val == curr.next.val)
				{
					curr = curr.next;  // loop on curr -> next -> next  when values is recurring
				}                                                               //curr
				prev.next = curr; //next after removing unnecceseries nodes go to last Node (1) -1 = 1 = 1 -> 1 -> 2 -> 2-> 2
				prev = curr;                                               //prev         // prev-1 curr-2  
				//prev = curr; // current node will become previous
				//curr = curr.next; // updating to next node
			}
			else
			{
				prev = curr; // when curr is only single and prev is going to here
				             // and curr go to next value (empl...2)   
			}
			curr = curr.next;
		}
		return dummyHead.next;
	}
} // TC: O(n), SC: O(1)