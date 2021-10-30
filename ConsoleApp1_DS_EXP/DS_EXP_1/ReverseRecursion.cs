using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_1
{
    public class ReverseRecursion
    {
        // Recursive C# program to reverse 
// a linked list 


public class ReverseLinkedListRecursive
	{

		/* Link list node */
		public class Node
		{
			public int data;
			public Node next;

			public Node(int nodeData)
			{
				this.data = nodeData;
				this.next = null;
			}
		}

	public	class LinkedList
		{
			public Node head;

			public LinkedList()
			{
				this.head = null;
			}

			public void insertNode(int nodeData)
			{
				Node node = new Node(nodeData);

				if (this.head != null)
				{
					node.next = head;
				}
				this.head = node;
			}
				public  int getCountRec(Node node)
				{
					// Base case  
					if (node == null)
						return 0;

					// Count is this node plus rest of the list  
					return 1 + getCountRec(node.next);
				}
				public int getCount()
				{
                    
					return getCountRec(head);
				}
				public static int countIteration(Node head)
				{
					int count = 0;
					Node temp = head;

					while (temp != null)
					{
						count++;
						temp = temp.next;
					}
					Console.WriteLine(" Length is  " + count);
					return count;
				}
			}

		/* Function to print linked list */
		public static void printSinglyLinkedList(Node node,
							String sep)
		{
			while (node != null)
			{
				Console.Write(node.data + sep);
				node = node.next;
			}
		}

		// Complete the reverse function below. 
		static Node reverse(Node head)
		{
			if (head == null)
			{
				return head;
			}

			// last node or only one node 
			if (head.next == null)
			{
				return head;
			}

			Node newHeadNode = reverse(head.next);

			// change references for middle chain 
			head.next.next = head;
			head.next = null;

			// send back new head 
			// node in every recursion 
			return newHeadNode;
		}
			
		// Driver code 
		public static void DisplayRevRecursionMain()
		{
                Console.WriteLine(" Inside DisplayRevRecursionMain()");
			LinkedList llist = new LinkedList();

			llist.insertNode(20);
			llist.insertNode(4);
			llist.insertNode(15);
			llist.insertNode(85);

			Console.WriteLine("Given linked list:");
			printSinglyLinkedList(llist.head, " ");
				Console.WriteLine();
				Console.WriteLine(" ************* ");
				Console.WriteLine(" Length is " + llist.getCount());
				Console.WriteLine();
				Console.WriteLine(" ************* ");
				LinkedList.countIteration(llist.head);

				Console.WriteLine();
			Console.WriteLine("Reversed Linked list:");
			Node llist1 = reverse(llist.head);
			printSinglyLinkedList(llist1, " ");
				Console.WriteLine();
				Console.WriteLine(" ************* ");
                Console.WriteLine( " Length is " + llist.getCount());
                Console.WriteLine();
				Console.WriteLine(" ************* ");
				LinkedList.countIteration(llist.head);
		}
	}

	// This code has been contributed by Rajput-Ji 

}
}
