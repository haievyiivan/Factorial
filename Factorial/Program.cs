using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter x
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine()); 

            ulong answer = 1; // Answer variable
            // After 21-23 variable will be full

            // Loop
            for (uint i = 1; i <= x; i++)
            {
                answer *= i;
            }

            // Write answer to the console
            Console.WriteLine($"{x}! = {answer}");

            // ReadKey
            Console.ReadKey();
        }
    }
}
