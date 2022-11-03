using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210140085_Ika_Tania_Chaerani
{
    class program
    {
        int[] arr = new int[33];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of elemnt in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 33))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 33 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter Array Element");
            Console.WriteLine("-------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);
            }
        }
        public void InsertionSort()
        {
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                {
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = arr[j];
                }
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("Input array element");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}