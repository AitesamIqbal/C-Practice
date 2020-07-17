using Microsoft.SqlServer.Server;
using System;
using System.Runtime.InteropServices;

namespace AsadConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2]; // Declaring array
            int[] abc = new int[2] { 10, 22 }; // declaring + initialize 
            int[] arr = new int[] { 10, 2, 20,15 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the value for index " + (i + 1));
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Value of Index " + (j + 1) + " is " + a[j]);
            }

            Console.ReadLine();
        }
    }
}
