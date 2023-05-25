<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
}

public class Node
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
public partial class BinarySearchTree
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

	public bool deleteBST(int value)
	{
		return Delete(root, value);
	}
	public bool Delete(Node currentNode, int value)
	{

		if (root == null)
		{
			return false;
		}

		Node parent = root; //To Store parent of currentNode
		while ((currentNode != null) && (currentNode.value != value))
		{
			parent = currentNode;
			if (currentNode.value > value)
				currentNode = currentNode.leftChild;
			else
				currentNode = currentNode.rightChild;

		}

		if (currentNode == null)
			return false;
		else if ((currentNode.leftChild == null) && (currentNode.rightChild == null))
		{
			//1. Node is Leaf Node
			//if that leaf node is the root (a tree with just root)
			if (root.value == currentNode.value)
			{

				root = null;
				return true;
			}
			else if (currentNode.value < parent.value)
			{

				parent.leftChild = null;
				return true;
			}
			else
			{

				parent.rightChild = null;
				return true;
			}

		}
		else if (currentNode.rightChild == null)
		{

			if (root.value == currentNode.value)
			{

				root = currentNode.leftChild;
				return true;
			}
			else if (currentNode.value < parent.value)
			{

				parent.leftChild = currentNode.leftChild;
				return true;
			}
			else
			{

				parent.rightChild = currentNode.leftChild;
				return true;
			}

		}
		else if (currentNode.leftChild == null)
		{
			if (root.value == currentNode.value)
			{

				root = currentNode.rightChild;
				return true;
			}
			else if (currentNode.value < parent.value)
			{

				parent.leftChild = currentNode.rightChild;
				return true;
			}
			else
			{

				parent.rightChild = currentNode.rightChild;
				return true;
			}

		}
		else
		{
			//Find Least Value Node in right-subtree of current Node
			Node leastNode = findLeastNode(currentNode.rightChild);
			//Set CurrentNode's Data to the least value in its right-subtree
			int tmp = leastNode.value;
			Delete(root, tmp);
			currentNode.value = leastNode.value;
			//Delete the leafNode which had the least value


			return true;
		}

	}

	//Helper function to find least value node in right-subtree of currentNode
	public Node findLeastNode(Node currentNode)
	{

		Node temp = currentNode;

		while (temp.leftChild != null)
		{
			temp = temp.leftChild;
		}

		return temp;

	}
	public void preOrderPrint(Node currentNode)
	{
		if (currentNode != null)
		{
			Console.WriteLine(currentNode.value);
			preOrderPrint(currentNode.leftChild);
			preOrderPrint(currentNode.rightChild);
		}
	}
}