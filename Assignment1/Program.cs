using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition:" + (i + j));
            Console.WriteLine("Subtraction:" + (i - j));
            Console.WriteLine("division:" + (i / j));
            Console.WriteLine("Mulltiplication:" + (i * j));
            Console.ReadKey();
        }

    }
}
