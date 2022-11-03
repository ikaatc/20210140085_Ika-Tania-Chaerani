using System;
using System.Collections.Generic;
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
        }
    }
}