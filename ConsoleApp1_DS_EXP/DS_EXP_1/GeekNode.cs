using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_1
{
    public class GeekNode
    {
        // C# prgram for the 
// above approach

public class GFG
	{

		public class Node
		{
			public int data;
			public Node next;

			// Constructor of Node
			public Node(int val)
			{
				this.data = val;
				this.next = null;
			}
		}

		static Node head = new Node(5);

		// Function prints the linked list
		// starting from the given node
		static void printList(Node n)
		{
			// Till n is not null
			while (n != null)
			{
				// Print the data
				Console.Write(n.data + " ");
				n = n.next;
			}
		}

		// Function to add a node before the
		// given node other than head node
		static Node addBefore(Node given_ptr,
							int val)
		{
			// First check if the given 
			// pointer is the address of 
			// head
			if (head == given_ptr)
			{
				// Create a new node
				Node n = new Node(val);

				// Point to next to current
				// head
				n.next = head;

				// Update the head pointer
				head = n;
				return n;
			}

			// Otherwise traverse the list 
			// to find previous node of 
			// given node
			else
			{
				Node p = null;

				// This loop will return p with
				// previous pointer of given node
				for (Node n = head; n != given_ptr;
					p = n, n = n.next) ;

				// Create a new node
				Node m = new Node(val);

				// Update the m.next
				m.next = p.next;

				// Update previous node's next
				p.next = m;

				return m;
			}
		}

		// Driver Code
		public static void DisplayGFGNODE()
		{
			// Head Node
			head.next = new Node(6);

			// Function Call
			addBefore(head.next, 8);

			// Print the linked List
			printList(head);
		}
	}

	// This code is contributed by shikhasingrajput

}
}
