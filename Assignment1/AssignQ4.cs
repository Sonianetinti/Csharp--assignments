using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ4
    {
        static void Main(string[] args)
        {
            AssignQ4.Swap();
        }
        public static void Swap()
        {
            int i, j;
            Console.WriteLine("Swapping of two numbers");
            Console.WriteLine("Enter the first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            j = Convert.ToInt32(Console.ReadLine());
            i = i + j;
            j = i - j;
            i = i - j;
            Console.WriteLine("After swap first number:" + i);
            Console.WriteLine("After swap second numbe:" + j);
            Console.ReadKey();
        }
    }
}
