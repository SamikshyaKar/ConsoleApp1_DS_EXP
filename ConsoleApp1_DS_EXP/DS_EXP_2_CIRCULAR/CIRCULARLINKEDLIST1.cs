using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_2_CIRCULAR
{
    class CIRCULARLINKEDLIST1
    {

        public class Program
        {
            //Represents the node of list.  
            public class Node<T>
            {
                public T data;
                public Node<T> next;
                public Node(T value)
                {
                    data = value;
                    next = null;
                }
            }

            public class CreateList<T>
            {
                protected Node<T> head = null;
                protected Node<T> tail = null;

                //This function will add the new node at the end of the list.  
                public void add(T data)
                {
                    //Create new node  
                    Node<T> newNode = new Node<T>(data);
                    //Checks if the list is empty.  
                    if (head == null)
                    {
                        head = newNode;
                        tail = newNode;
                        newNode.next = head;
                    }
                    else
                    {
                        //tail will point to new node.  
                        tail.next = newNode;
                        //New node will become new tail.  
                        tail = newNode;
                        //Since, it is circular linked list tail will point to head.  
                        tail.next = head;
                    }
                }

                //Displays all the nodes in the list  
                public void display()
                {
                    Node<T> current;
                    if (head == null)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        //Prints each node by incrementing pointer.  
                        Console.WriteLine("Nodes of the circular linked list: ");
                        Console.Write(" " + head.data);
                        for (current = head.next; current != head; current = current.next)
                        {
                            Console.Write(" " + current.data);
                        }
                    }
                }
            }

            public static void Display_CIRCULARLIST()
            {
                Console.WriteLine();
                Console.WriteLine(" Inside Display_CIRCULARLIST()");

                CreateList<int> cl = new CreateList<int>();
                //Adds data to the list  
                cl.add(1);
                cl.add(2);
                cl.add(3);
                cl.add(4);
                //Displays all the nodes present in the list  
                cl.display();
            }
        }
    }
}

