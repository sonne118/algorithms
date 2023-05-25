<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

static void Main(string[] args)
{
	BinarySearchTree BST = new BinarySearchTree(13);

	BST.insertBST(4);
	BST.insertBST(7);
	BST.insertBST(16);

	Console.WriteLine("InOrderTraversal");
	BST.inOrderPrint(BST.getRoot());
	Console.WriteLine("Delete 12");
	Console.WriteLine(BST.deleteBST(12));
	return;
}


	class Node
	{
		public int value;
		public Node leftChild;
		public Node rightChild;
		public Node()
		{
			value = 0;
			leftChild = null;
			rightChild = null;
		}

		public Node(int val)
		{
			value = val;
			leftChild = null;
			rightChild = null;
		}
	}
	class BinarySearchTree
	{
		Node root;
		public BinarySearchTree(int rootValue)
		{
			root = new Node(rootValue);
		}
		public BinarySearchTree()
		{
			root = null;
		}
		public Node getRoot()
		{
			return root;
		}
		public Node insert(Node currentNode, int val)
		{
			if (currentNode == null)
			{
				return new Node(val);
			}
			else if (currentNode.value > val)
			{

				currentNode.leftChild = insert(currentNode.leftChild, val);

			}
			else
			{
				currentNode.rightChild = insert(currentNode.rightChild, val);
			}

			return currentNode;

		}

		public void insertBST(int value)
		{

			if (getRoot() == null)
			{
				root = new Node(value);
				return;
			}
			insert(this.getRoot(), value);
		}

		public void inOrderPrint(Node currentNode)
		{
			if (currentNode != null)
			{
				inOrderPrint(currentNode.leftChild);
				Console.WriteLine(currentNode.value);
				inOrderPrint(currentNode.rightChild);
			}
		}
		Node searchBST(int value)
		{

			//let's start with the root 
			Node currentNode = root;
			while ((currentNode != null) && (currentNode.value != value))
			{
				//the loop will run until the currentNode IS NOT null
				//and until we get to our value
				if (value < currentNode.value)
				{
					//traverse to the left subtree
					currentNode = currentNode.leftChild;
				}
				else
				{ //traverse to the right subtree
					currentNode = currentNode.rightChild;

				}

			}
			//after the loop, we'll have either the searched value
			//or null in case the value was not found
			return currentNode;
		}
		public Node search(Node currentNode, int value)
		{
			if (currentNode == null)
				return null;
			else if (currentNode.value == value)
				return currentNode;
			else if (currentNode.value > value)
				return search(currentNode.leftChild, value);
			else
				return search(currentNode.rightChild, value);
		}
		public bool Delete(Node currentNode, int value)
		{
			if (root == null)
			{
				return false;
			}
			// Search for the tree for the given data
			while (currentNode != null && (currentNode.value != value))
			{

				if (currentNode.value > value)
					currentNode = currentNode.leftChild;
				else
					currentNode = currentNode.rightChild;
			}
			// Return true if currentNode is not null
			if (currentNode != null)
				return true;

			return false;
		}
		public bool deleteBST(int value)
		{
			return Delete(root, value);
		}
	}
