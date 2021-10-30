using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_DS_EXP.SORT_Practice
{
   public class sortInsertion
    {
        public static void InsertionVoid()
        {
            int[] arr = new int[] { 12, 56, 8, 90, 34, 16, 76, 26, 1 };
            Console.WriteLine(" The Unsorted array ");
            foreach(int i in arr)
            {
               Console.Write(" " + i);
            }
            Console.WriteLine();
        
            InsertionSORTing(arr);

            Console.WriteLine(" The Sorted Array ");
            foreach (int i in arr)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine(); 
        }

        private static void InsertionSORTing(int[] arr)
        {
            for(int i = 1;i<arr.Length;i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
