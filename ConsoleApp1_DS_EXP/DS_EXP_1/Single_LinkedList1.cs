using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_1
{
    public class Single_LinkedList1
    {

        public class TheLinkedList1
        {
            public Node head = null;
            public Node tail = null;

            public void AddLast(object data)
            {
                Node newitem = new Node();
                newitem.data = data;

                if (head == null)
                {
                    head = newitem;
                    tail = newitem;

                }
                else
                {
                    tail.next = newitem;
                    tail = newitem;
                }
            }

            public void AddFirst(object data)
            {
                Node newitem = new Node();
                newitem.data = data;

                if (head == null)
                {
                    head = newitem;
                    tail = newitem;

                }

                else
                {
                    newitem.next = head;
                    head = newitem;

                }

            }

            public void ReadAll()
            {

                Node current = head;

                while (current.next != null)

                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }

                Console.WriteLine(current.data);

            }

            public void Remove(object data)

            {
                Node current = head;
                Node newitem = new Node();
                newitem.data = data;

                if (head == null)
                {
                    Console.WriteLine("Empty List: No Item to be removed");
                }

                if (data == head.data)
                {
                    head = head.next;
                }

                while (current.next != null)
                {
                    if (current.next.data == data)
                    {
                        current.next = current.next.next;

                    }
                    current = current.next;

                }

            }

            public void RemoveHead()
            {
                Console.WriteLine("Inside Remove Head");

                if (head == null)
                {
                    Console.WriteLine("Empty ");

                }

                head = head.next;
                Console.WriteLine("New Head is " + head.data);
            }

            public void RemoveTail()
            {
                Node previousToTail = head;
                while (previousToTail.next != tail)

                    previousToTail = previousToTail.next;

                tail = previousToTail;

                tail.next = null;
                Console.WriteLine(" OLD Tail Removed ");
                Console.WriteLine(" NEW TAIL is " + tail.data);
            }

            //public void removeNext(Node previous)
            //{
            //    if (previous == null)

            //    {
            //        if (head == null) return;

            //        else
            //        {
            //            if (head == tail)
            //            {
            //                head = null;

            //                tail = null;
            //            }
            //            else
            //            {
            //                head = head.next;
            //            }

            //        }

            //    }


            //    if (previous.next == tail)
            //    {

            //        tail = previous;

            //        tail.next = null;

            //    }
            //    else if (previous == tail)

            //        return;

            //    else
            //    {

            //        previous.next = previous.next.next;

            //    }


            //}

            //public void removeNext(object data)
            //{

            //    Node previous=new Node();
            //    previous.data = data;
            //    if (previous == null)

            //    {
            //        if (head == null) return;

            //        else
            //        {
            //            if (head == tail)
            //            {
            //                head = null;

            //                tail = null;
            //            }
            //            else
            //            {
            //                head = head.next;
            //            }

            //        }

            //    }


            //    if (previous.next == tail)
            //    {

            //        tail = previous;

            //        tail.next = null;

            //    }
            //    else if (previous == tail)

            //        return;

            //    else
            //    {

            //        previous.next = previous.next.next;

            //    }


            //}
        }

    }
}
