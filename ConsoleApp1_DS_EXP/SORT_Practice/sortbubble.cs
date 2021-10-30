using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.SORT_Practice
{
   public  class sortbubble
    {
        public static void buublesorting()
        {
            int[] arr = new int[10] { 23, 78, 1, 90, 54, 12, 65, 89, 10, 87 };
            Console.WriteLine(" The Unsorted array ");
            foreach (int i in arr)
            {
                Console.Write(" " +i);
            }
            Console.WriteLine();
            Console.WriteLine(" The Sorted array " );
            BubbleSORT(arr);
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }

        private static void BubbleSORT(int[] arr)
        {
            for(int i=0;i<arr.Length-1; i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
