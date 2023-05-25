<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

static void Main(string[] args)
{
BinarySearchTree BST = new BinarySearchTree(13);
BST.insertBST(4);
BST.insertBST(7);
BST.insertBST(16);
BST.insertBST(19);
BST.insertBST(3);
BST.insertBST(1);
BST.insertBST(9);
BST.insertBST(2);

Console.WriteLine("InOrderTraversal");
BST.inOrderPrint(BST.getRoot());
Console.WriteLine("Search");
Console.WriteLine((BST.searchBST(3)).value);
if (BST.searchBST(11) != null)
Console.WriteLine("Value Found!");
else
Console.WriteLine("Value Not Found!");
return;
}
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
		public void insertBST(int val)
		{
			if (getRoot() == null)
			{
				root = new Node(val);
				return;
			}
			//starting from the root
			Node currentNode = root;
			Node parent = root;
			//while we get to the null node
			while (currentNode != null)
			{
				parent = currentNode; //update the parent
				if (val < currentNode.value)
				{
					//if newValue < currentNode.val,
					//iterate to the left subtree
					currentNode = currentNode.leftChild;
				}
				else
				{
					//if newValue >= currentNode.val,
					//iterate to the right subtree
					currentNode = currentNode.rightChild;
				}
			}
			//by now, we will have the parent of the null
			//node where we have to insert the newValue
			if (val < parent.value)
			{
				//if newValue < parent.val
				//insert into the leftChild
				parent.leftChild = new Node(val);
			}
			else
			{
				//if newValue >= parent.val
				//insert into the rightChild
				parent.rightChild = new Node(val);
			}
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
		public Node searchBST(int value)
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
	}
