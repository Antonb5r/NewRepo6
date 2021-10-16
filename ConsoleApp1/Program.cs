using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] myarray = { 3, 5, 6, 1, 9, 6, 4, 3, 9, 8, -5, 1, 5, 14, -54, 5, 32, 54, 26, 2 };
            for (int i = 0; i < myarray.Length; i++)
            {
                if (i <= myarray.Length - 2)
                {
                    if ((myarray[i] % 3 == 0 || myarray[i + 1] % 3 == 0) && (myarray[i] % 3 != 0 || myarray[i + 1] % 3 != 0))
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine("Делится на три: " + count + " пар");
            Console.WriteLine("Длинна массива: " + myarray.Length);
            Console.ReadLine();
        }
    }
}
