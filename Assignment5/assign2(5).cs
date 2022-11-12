using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class EMP
    {
        public static void Main()
        {
            ArrayList employee = new ArrayList();
            employee.Add(1);
            employee.Add("jimmy");
            employee.Add("74680");
            employee.Add("hyderabad");
            Console.WriteLine("emp id: "+employee[0]);
            Console.WriteLine("employee name : " + employee[1]);
         
            Console.WriteLine("employee Salary : " + employee[2]);
           
            Console.WriteLine("employee city : "+ employee[3]);
            Console.ReadKey();
            
        }

    }
}
