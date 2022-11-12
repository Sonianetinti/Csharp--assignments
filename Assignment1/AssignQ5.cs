using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ5
    {
        static void Main(string[] args)
        {
            AssignQ5.Circle();
        }
        public static void Circle()
        {
            int r;
            double pi = 3.14;
            Console.WriteLine("radius:");
            r = Convert.ToInt32(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Area of  the circle:" + area);
            double circumference = 2 * pi * r;
            Console.WriteLine("circumference of the circle:" + circumference);
            Console.ReadKey();
        }

    }
}
