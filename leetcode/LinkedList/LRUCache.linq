<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>


public class LFUCache
{
	private class Node
	{
		public Node prev;
		public Node next;
		public int key;
		public int value;

		public Node(int key, int value)
		{
			this.key = key;
			this.value = value;
			this.prev = null;
			this.next = null;
		}
	}

	private int capacity;
	private Dictionary<int, Node> hs = new Dictionary<int, Node>();
	private Node head = new Node(-1, -1);
	private Node tail = new Node(-1, -1);

	public LFUCache(int capacity)
	{
		this.capacity = capacity;
		tail.prev = head;
		head.next = tail;
	}

	public int Get(int key)
	{
		if (!hs.ContainsKey(key))
		{
			return -1;
		}
		Node value;
		Node current = hs[key];
		current.prev.next = current.next;
		current.next.prev = current.prev;
		moveToTail(current);
		return hs[key].value;
	}

	public void Put(int key, int value)
	{
		if (Get(key) != -1)
		{
			hs[key].value = value;
			return;
		}

		if (hs.Count() == capacity)
		{
			hs.Remove(head.next.key);
			head.next = head.next.next;
			head.next.prev = head;
		}

		Node insert = new Node(key, value);
		hs.Add(key, insert);
		moveToTail(insert);
	}

	private void moveToTail(Node current)
	{
		current.prev = tail.prev;
		tail.prev = current;
		current.prev.next = current;
		current.next = tail;
	}
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */