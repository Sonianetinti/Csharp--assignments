using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ3
    {
        static void Main(string[] args)
        {
            AssignQ3.Sum1(8,6,5,4,3);
        }
        public static void Sum1(params int[] number)
        {
            
            int result = number[0] + number[1] + number[2] + number[3] + number[4];
            Console.WriteLine("Sum of the numbers {0}", result);
            Console.ReadKey();

        }
    }
}
