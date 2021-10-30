using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.DS_EXP_1
{
    public class SingleLinkedList2
    {
        public Node head = null;
        public Node tail = null; 
         

        public void AddFIRST(object data)
        {
            Node newitem = new Node();
            newitem.data = data;

            if(head==null)
            {
                Console.WriteLine(" Empty List ");
                head = newitem;
                Console.WriteLine(" The New HEAD   is " + head.data);
                Console.WriteLine(" The New HEAD DATA " + newitem.data);
                tail = head;
                Console.WriteLine(" the tail and Head are same And tail is " + tail.data);
            }
            else
            {
                Console.WriteLine(" The Present head before insertion is " +head.data);
                newitem.next = head;
                head = newitem;
                Console.WriteLine(" Now the head changed after insertion is " + head.data);
                Console.WriteLine(" The TAIL is " + tail.data);

            }
        }

       

        public void AddLAST(object data)
        {
            Console.WriteLine(" Add the Last Element as TAIL " );
            if (tail !=null)
            {
                Console.WriteLine(" The Present TAIL is " + tail.data); 
            }
            Node newitem = new Node();
            newitem.data = data;
            if (head==null)
            {
                Console.WriteLine(" An empty list ");
                head = newitem;
                tail = newitem;
                Console.WriteLine(" The New head and tail are " + head.data + " tail : " + tail.data);
            }
            else if (head==tail)
            {
                Console.WriteLine(" Only Onle Element in the LIST " );
                Console.WriteLine(" Current tail is " + tail.data);
                Console.WriteLine(" The new tail is " );
                tail.next = newitem;
                tail = newitem;
                tail.next = null;
                Console.WriteLine(" The new tail is " + tail.data);
            }
            else
            {
                Console.WriteLine(" Current tail is " + tail.data);
                Console.WriteLine(" The new tail is ");
                tail.next = newitem;
                tail = newitem;
                tail.next = null;
                Console.WriteLine(" The new tail is " + tail.data);
            }
        }

        public void ReadAll()
        {
            Node current = head;

            Console.WriteLine(" The Linkedlist elements are ");
            while (current.next != null)
            {
                Console.Write("  " + current.data);
                current = current.next;
            }
            Console.Write(" " + current.data);
            Console.WriteLine();
        }

        //public void insertafter(object prevdata, object newdata)
        //{
        //    Node newitetmtobeinserted = new Node();
        //    newitetmtobeinserted.data = newdata;

        //    Node previtemtobeinserted = new Node();
        //    previtemtobeinserted.data = prevdata;

        //    if (prevdata==null)
        //    {
        //        Console.WriteLine(" Add HEAD HERE NEWDATA ");
        //        AddFIRST(newdata);
        //    }
        //    else if (newdata==null)
        //    {
        //        Console.WriteLine(" Nothing to be inserted ");
        //        return;
        //    }
        //    else
        //    {
        //        newitetmtobeinserted.next = previtemtobeinserted.next;
        //        previtemtobeinserted.next = newitetmtobeinserted;
        //        Console.WriteLine(" The Inserted data " + newitetmtobeinserted.data);
        //        //Node temp = new Node();
        //        //temp.next= previtemtobeinserted.next;
        //        //previtemtobeinserted.next = newitetmtobeinserted;
        //        //newitetmtobeinserted.next = temp.next;
        //    }
        //}

        public void insertafter2(Node prevNode, object newdata)
        {         
            if (prevNode == null)
            {               
                Console.WriteLine(" Prevous Node " + prevNode + " Cant be null ");
                return;
            }

            Node newitetmtobeinserted = new Node();
            newitetmtobeinserted.data = newdata;
            newitetmtobeinserted.next = prevNode.next;
            prevNode.next = newitetmtobeinserted;
          Console.WriteLine(" The Inserted data " + newitetmtobeinserted.data);             
            
        }

        //public void InsertBefore(object newdata, Node nextNode)
        public void InsertBefore()
        {
            Console.WriteLine(" Enter the Data to be Inserted ");
            object newdata = Console.ReadLine();
            Console.WriteLine(" Enter value before which data to be inserted ");
            object val =  Console.ReadLine();
            Node newitem = new Node();
            newitem.data = newdata;
            //Node current = head;
            //Node CurrentPrev = null;
            //while(current.data !=val)
            //{
            //    //CurrentPrev = current;
            //    //CurrentPrev.next = current;
            //    current = current.next;
            //}

            //CurrentPrev.next = newitem;
            //newitem.next = current;

            Node currentPrev = head;
            Node current = currentPrev.next;
            while(!current.data.Equals(val))
            {
                currentPrev = current;
                current = current.next;
            }
            currentPrev.next = newitem;
            newitem.next = current;
        }

        public void InsertBefore2(Node GivenNode, int newval)
        {
            Node prev = null;


            for (Node Now = head; Now != GivenNode; prev = Now, Now = Now.next) ;

            Node mid = new Node();

            mid.data = newval;
            mid.next = prev.next;
            prev.next = mid;

        }

        public void InsertBefore2_variation1(Node GivenNode, object newval)
        {
            Node prev = null;


            for (Node Now = head; Now != GivenNode; prev = Now, Now = Now.next) ;

            Node mid = new Node();

            mid.data = newval;
            mid.next = prev.next;
            prev.next = mid;

        }

        public void InsertBefore2_variation2_while(Node GivenNode, object newval)
        {
            Node TobeInsertedBefore = new Node();
            TobeInsertedBefore.data = newval;
            Node prev = null;
            Node current = head;

            while (current != GivenNode)
            {
                prev = current;
                current = current.next;
            }

            prev.next = TobeInsertedBefore;
            TobeInsertedBefore.next = current;





            //    for (Node Now = head; Now != GivenNode; prev = Now, Now = Now.next) ;

            //Node mid = new Node();

            //mid.data = newval;
            //mid.next = prev.next;
            //prev.next = mid;
        }

        public void InsertBefore2_variation2_while_var2(Node GivenNode, object newval)
        {
            Node TobeInsertedBefore = new Node();
            TobeInsertedBefore.data = newval;
            Node prev = null;
            Node current = head;

            while (current != GivenNode)
            {
                prev = current;
                current = current.next;
            }

            TobeInsertedBefore.next = prev.next;
            prev.next = TobeInsertedBefore;
            //TobeInsertedBefore.next = current;
         
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

        public void Remove(object data)

        {
            Console.WriteLine(" Inside Remove data ");
            Node current = head;           

            if (head == null)
            {
                Console.WriteLine("Empty List: No Item to be removed");
            }

            if (data == head.data)
            {
                head = head.next;
            }
            //Node Prev = null;
            //while(current !=null && current.data!=data)
            //{
            //    Prev = current;
            //    current = current.next;
            //}

            //if(current==null)
            //{
            //    return;
            //}
            //Prev.next = current.next;

            //while(current !=tail)
            //{
            //    if(current.next.data==data)
            //    {
            //        current.next = current.next.next;
            //    }
            //    current = current.next;
            //}

            while (current.next != null)
            {
                if (current.next.data.Equals(data))
                {
                    current.next = current.next.next;

                }
                current = current.next;

            }

        }

        public void  Removefrommidvariation(object data)
        {
            Console.WriteLine(" Inside  Removefrommidvariation(object data) ");
            Node Prev = null;
            Node current = head;
            while (current != null && (!(current.data.Equals(data))))
            {
                Prev = current;
                current = current.next;
            }

            if (current == null)
            {
                return;
            }
            Prev.next = current.next;           
        }

        public void RemoveVariedVariation(object data)
        {
            Console.WriteLine("RemoveVariedVariation(object data)");
            Node current = head;
            while (current != tail)
            {
                if (current.next.data.Equals(data))
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }

        }
        public void Removewhole()
        {
            head = null;           
            Console.WriteLine(" List Removed ");
        }

        public int length()
        {
            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine(" Length is " + count);
            return count;
        }

        //public int length_Variation1()
        //{

        //    Node temp = this.head;
        //    int count = 0;
        // This is wrong //
        //    while (temp.next!=null)  // This is wrong //
        //    {
        //        count++;
        //        temp = temp.next;
        //    }
        //    Console.WriteLine(" from length_Variation1() -- Length is  " + count);
        //    return count;
        //}
        public void Deletedata(int key )
        {
            Console.WriteLine(" Inside Deleted data ");
            Node temp = head;
            Node Prev = null;

            while (temp != null && temp.data != (object)key)
            {
                Prev = temp;
                temp = temp.next;
            }
            if (temp == null )
            {
                return;
            }
            Prev.next = temp.next;

        }

        public void deleteNode(Node tobedeleted)
        {
            Node temp = head; Node prev = null;
            while(temp !=null && temp !=tobedeleted)
            {
                prev = temp;
                temp = temp.next;
                
            }
            if (temp == null)
            {
                Console.WriteLine(" Empty List ");
            }
            prev = tobedeleted.next;
            Console.WriteLine(" ITEM DLETED " + tobedeleted.data);

        }
        public void deleteNode_Medium(Node node)
        {
            Console.WriteLine(" Inside deleteNode_Medium ");
            Console.WriteLine(" ITEM DELETED " + node.data);

            if (node.next == null)
            {
                node = null;
                return;
            }
            node.data = node.next.data;
            node.next = node.next.next;
        }

        //public bool Search (object x)
        //{
        //    Node current = head;
        //    while(current !=null)
        //    {
        //        if (current.data==x)
        //        {
        //            Console.WriteLine(" Data found ");
        //            return true;                  
        //        }
        //        current = current.next;
        //    }
        //    Console.WriteLine(" Data not found ");
        //    return false;
        //}

        public bool Search1(object x)
        {
            Console.WriteLine(" Inside Search1 ");
            Node current = head;
            while (current != null)
            {
                if (current.data.Equals(x) )
                {
                    Console.WriteLine(" Data found ");
                    Console.WriteLine(" Data found "+x);
                    Console.WriteLine(" Location " + current.data);
                    return true;
                }
                current = current.next;
            }
            Console.WriteLine(" Data not found ");
           
            return false;
        }

        public void ReverseList()
        {
            Console.WriteLine(" Inside ReverseList ");
            Node next = null;
            Node prev = null;
            Node current=head;
            while (current !=null)
            {
                next = current.next;
                current.next=prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

       public   Node reverseRECURSE(Node head)
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

            Node newHeadNode = reverseRECURSE(head.next);

            // change references for middle chain 
            head.next.next = head;
            head.next = null;

            // send back new head  
            // node in every recursion 
            return newHeadNode;
        }

        public  void printreverseRECURSE(Node node,
                       String sep)
        {
            Console.WriteLine(" +++++  Inside reverseRECURSE To Print printreverseRECURSE  ");
            while (node != null)
            {
                Console.Write(node.data + sep);
                node = node.next;
            }
        }


        public void reverseRECURSE2(Node head)
        {

            if (head == null)
            {
                Console.WriteLine(" EMPTY LIST ");
                Console.WriteLine(head.data);
                return;
            }

            // last node or only one node 
            if (head.next == null)
            {
                Console.WriteLine(" ONE ELEMENT ONLY in the  LIST ");
                Console.WriteLine(head.data);
                return;
            }

            reverseRECURSE2(head.next);

            // change references for middle chain 
            head.next.next = head;
            head.next = null;

            // send back new head  
            // node in every recursion 
            
        }

    }
}
