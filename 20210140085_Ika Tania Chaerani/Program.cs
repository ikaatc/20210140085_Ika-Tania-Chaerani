using System;
using System.Collections;
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
        static public void MainMerge(int[] j, int low, int mid, int high)
        {
            int[] arr = new int[33];
            int i, a, b, c;
            a = (mid - 1);
            b = low;
            c = (high - low + 1);

            while ((low <= a) && (mid <= high))
            {
                if (j[low] <= j[mid])
                    arr[c++] = j[low++];
                else
                    arr[c++] = j[mid++];
            }
            while (low <= a)
                j[c++] = j[low++];
            while (mid <= high)
                j[c++] = j[mid++];
            for (i = 0; i <= b; i++)
            {
                j[high] = arr[high];
                high--;
            }
        }
        public void MergeSort(int[] j, int low, int high)
        {
            int mid;
            if (high > low)
            {
                mid = (high + low) / 2;
                MergeSort(j, low, mid);
                MergeSort(j, (mid + 1), high);
                MainMerge(j, low, (mid + 1), high);
            }
        }
        static void Main(string[] args)
        {
            program p = new program();
            int pilihanmenu;

            do
            {
                Console.WriteLine("Pilihan Menu");
                Console.WriteLine("");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Merge Sort");
                Console.WriteLine("3. exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Insertion Sort");
                        p.input();
                        p.InsertionSort();
                        p.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Merge Sort");
                        p.input();
                        p.display();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                }
                Console.WriteLine("press return to exit");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}