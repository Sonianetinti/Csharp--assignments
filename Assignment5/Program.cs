using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Program
    {
        int[] elements = new int[] { 655, 10, 30, 49 };
        int[] arr = new int[3];
        string[] ele = new string[] { "hari", "soni", "scott" };
        public void Sort()
        {
            Array.Sort(elements);
            foreach (int i in elements)
            {
                Console.WriteLine(i);
            }
            Array.Sort(ele);
            foreach (string i in ele)
            {
                Console.WriteLine(i);
            }
        }
        public void Reverse()
        {
            Array.Reverse(elements);
            foreach (int i in elements)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(ele);
            foreach (string i in ele)
            {
                Console.WriteLine(i);
            }
        }
        public void Copy()
        {
            Array.Copy(elements, 0, arr, 0, 2);  
            foreach(int  value in arr)
            {
                Console.WriteLine(value);
            }
        }
        public void Clear()
        {
            Array.Clear(elements, 0, elements.Length);
            foreach (int j in elements)
            {

                Console.WriteLine(j);
            }

        }

        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine("elements sorted are:");
            p.Sort();
            Console.WriteLine("after reverse of elements");
            p.Reverse();
            Console.WriteLine("Copy of elements to arr");
            p.Copy();
            Console.WriteLine("Clearing the elements");
            p.Clear();  

            Console.ReadKey();
        }
    }
}