<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>



  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

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
  }


public class Solution
{
	public bool IsSubPath(ListNode head, TreeNode root)
	{
		if (head == null) return true;
		if (root == null) return false;
		if (head.val == root.val)
		{
			bool temp = startsWith(head, root);
			if (temp) return true;
		}
		return IsSubPath(head, root.left) || IsSubPath(head, root.right);
	}

	public bool startsWith(ListNode head, TreeNode node)
	{
		if (head == null) return true;
		if (node == null) return false;
		if (head.val != node.val) return false;
		return startsWith(head.next, node.left) || startsWith(head.next, node.right);
	}

}