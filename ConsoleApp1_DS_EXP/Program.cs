using System;
using System.Collections.Generic;
using ConsoleApp1_DS_EXP.DS_EXP_1;
using ConsoleApp1_DS_EXP.SORT_Practice;
using ConsoleApp1_DS_EXP.DS_EXP_2_CIRCULAR;
using ConsoleApp1_DS_EXP.Double_LinkedList;

namespace ConsoleApp1_DS_EXP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //sortbubble.buublesorting();
            //sortInsertion.InsertionVoid();
            //Single_LinkedList1.TheLinkedList1 obj = new Single_LinkedList1.TheLinkedList1();
            //obj.AddLast(10);
            //obj.AddFirst("samu");
            //obj.AddLast(20);
            //obj.AddLast(30);
            //obj.AddLast(80);
            //obj.AddLast(50);
            //obj.AddLast(100);
            //obj.AddLast(" RAMAYA ");
            //obj.AddLast("TINKU");
            //Console.WriteLine(" READ ");
            //obj.ReadAll();

            //obj.RemoveHead();
            //Console.WriteLine(" READ RemoveHead() ");
            //obj.ReadAll();
            //Console.WriteLine(" REMOVE TAIL");
            //obj.RemoveTail();
            //obj.ReadAll();
            //obj.Remove(50);
            //obj.ReadAll();
            SingleLinkedList2 Obj2 = new SingleLinkedList2();
            Obj2.AddFIRST(10);
            Obj2.AddFIRST(20);
            Obj2.ReadAll();
            Obj2.AddLAST(50);
            Obj2.ReadAll();
            //Obj2.insertafter(20, 70);
          
            Console.WriteLine("working with NODE PARAMETER " );
            Obj2.insertafter2(Obj2.head, 71);
            Obj2.ReadAll();
            Console.WriteLine(" ********* ");
            Obj2.insertafter2(Obj2.head.next, 75);
            Obj2.ReadAll();
            Console.WriteLine(" **!!!!!!!!!****");
            Obj2.insertafter2(Obj2.head.next.next, 7500);
            Obj2.ReadAll();
            Obj2.insertafter2(Obj2.head, " Samu ");
            Obj2.ReadAll();
            //Obj2.InsertBefore();
            //Obj2.ReadAll();
            GeekNode.GFG.DisplayGFGNODE();
            Obj2.InsertBefore2(Obj2.head.next, 67);
            Obj2.ReadAll();
            Obj2.InsertBefore2_variation1(Obj2.head.next, "Dhamu ");
            Obj2.ReadAll();
            Obj2.InsertBefore2_variation2_while(Obj2.head.next, 1222.7878);
            Obj2.ReadAll();
            Obj2.InsertBefore2_variation2_while_var2(Obj2.head.next, 0.00123F);
            Obj2.ReadAll();
            Obj2.length();         
            Obj2.RemoveTail();
            Obj2.ReadAll();
            Obj2.RemoveHead();
            Obj2.ReadAll();          
            Obj2.length();
            Obj2.Deletedata(7500);
            Obj2.ReadAll();
            Obj2.AddLAST(450);
            Obj2.ReadAll();
            Obj2.AddLAST("CTC");
            Obj2.ReadAll();
            Obj2.AddLAST(12000);
            Obj2.ReadAll();
            Obj2.Remove(450);
            Obj2.ReadAll();
            Obj2.length();
            Obj2.AddLAST(24000);
            Obj2.ReadAll();
            Obj2.AddLAST(1234.7865);
            Obj2.ReadAll();
            Obj2.AddLAST(111);          
            Obj2.ReadAll();
            Obj2.Removefrommidvariation(24000);
            Obj2.ReadAll();
            Obj2.AddLAST(77777);
            Obj2.ReadAll();
            Obj2.AddLAST(55);
            Obj2.ReadAll();
            Obj2.AddLAST(555555);
            Obj2.ReadAll();
            Obj2.RemoveVariedVariation(77777);
            Obj2.ReadAll();
            //Obj2.Search(7500);
            Obj2.Search1(7500);
            Obj2.deleteNode(Obj2.head.next.next.next.next.next.next.next);
            Obj2.ReadAll();
            Obj2.length();
            Obj2.deleteNode_Medium(Obj2.head.next.next.next.next.next.next.next);
            Obj2.ReadAll();
            Obj2.length();
            Obj2.deleteNode_Medium(Obj2.head.next.next.next.next.next.next.next);
            Obj2.ReadAll();
            Obj2.length();
           /* Obj2.InsertBefore();*/ //wrong
            Obj2.ReadAll();
            Console.WriteLine("**********");
            Obj2.length();
            Obj2.ReverseList();
            Obj2.ReadAll();
            Console.WriteLine("**********");
            Obj2.length();
            //Node rev1= Obj2.reverseRECURSE(Obj2.head);
            //Obj2.ReadAll();
            //Obj2.printreverseRECURSE(rev1, ", ");
            Obj2.length();
            //Obj2.reverseRECURSE2(Obj2.head);//wrong
            Obj2.ReadAll();
            Obj2.length();
            Obj2.Removewhole();
            //Obj2.ReadAll();
            Obj2.length();
            ReverseRecursion.ReverseLinkedListRecursive.DisplayRevRecursionMain();
            ReverseRecursion.ReverseLinkedListRecursive.LinkedList oblj = new ReverseRecursion.ReverseLinkedListRecursive.LinkedList();
            ReverseRecursion.ReverseLinkedListRecursive.LinkedList.countIteration(oblj.head);
            Console.WriteLine(" The count of the lists are " + oblj.getCount());
            Console.WriteLine();
            Console.WriteLine("                                  CIRCULAR ");
            Console.WriteLine(String.Format(" {0,-10}", "  CIRCULAR LINKED LIST "));
            Console.WriteLine(String.Format(" {0,-30}", "  CIRCULAR LINKED LIST "));
            Console.WriteLine(String.Format(" {0,20}", "  CIRCULAR LINKED LIST "));
            Console.WriteLine(String.Format(" {0,-20}", "  CIRCULAR LINKED LIST "));
            CircularSingle1.GFG.DisplayCircular();
            CircularList1.Circlist.DisplayCircularListSingle();
            CIRCULARLINKEDLIST1.Program.Display_CIRCULARLIST();
            Console.WriteLine();

            Console.WriteLine("                    DOUBLE LINKED LIST ");
            Console.WriteLine("                    DOUBLE LINKED LIST  " );
             static string Indent(int count)
            {
                return "  ".PadLeft(count);
            }
            Console.WriteLine(Indent(6) + "DOUBLE LINKED LIST " );
            Console.WriteLine(Indent(16) + "DOUBLE LINKED LIST " );
            Console.WriteLine("-------------------------------");           
            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
            Console.WriteLine(string.Format(" {0,-10}","  DOUBLE LINKEDLIST "));
            Console.WriteLine(String.Format(" {0, 10}", "  DOUBLE LINKEDLIST "));
            DLINKEDLIST1.DLinkedList.DISPLAY_DOUBLE();
            Dlink1List1.Implementation.DoubleLinkDisplay();
            geekdouble.DLL.DisplayGeekDouble();
        }
    }
}
