using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.Double_LinkedList
{
   public  class Dlink1List1
    {
      public  class Node
        {
            public int data=0;
            public Node next=null;
            public Node prev = null;
        };

        public class LinkedList
        {
            //public Node head = null;
            public Node head;
            public LinkedList()
            {
                head = null;
            }

            internal void DisplayPrintDouble_forward()
            {
                Node temp = new Node();
                temp = head;
                if (temp !=null)
                {
                    Console.WriteLine(" The Forward List Is As follows " );
                    while(temp !=null)
                    {
                        Console.Write(" " + temp.data);
                        temp = temp.next;
                    }

                }
                else
                {
                    Console.WriteLine(" List is Empty. ");
                }
            }

            internal void DisplayPrintDouble_backward()
            {
                Console.WriteLine();
                Console.WriteLine(" The Backward List Is As follows ");
                Node temp = new Node();
                temp = head;
                Node last = temp;
                if (temp != null)
                {
                    
                    while (temp != null)
                    {
                        //Console.Write(" " + temp.data);
                        last = temp;
                        temp = temp.next;
                    }

                }
                else
                {
                    Console.WriteLine(" List is Empty. ");
                }

                while(last !=null)
                {
                    Console.Write(" " + last.data);
                    last = last.prev;
                }
                Console.WriteLine();
            }
        }

        public  class Implementation
        {
            public static void DoubleLinkDisplay()
            {
                LinkedList myLink = new LinkedList();

                Node first = new Node();
                first.data = 10;
                first.next = null;
                first.prev = null;
                myLink.head = first;


                //Add second node.
                Node second = new Node();
                second.data = 20;
                second.next = null;
                //linking with first node
                second.prev = first;
                first.next = second;

                //Add third node.
                Node third = new Node();
                third.data = 30;
                third.next = null;
                //linking with second node
                third.prev = second;
                second.next = third;

                myLink.DisplayPrintDouble_forward();
                myLink.DisplayPrintDouble_backward();
            }

        }


    }
}
