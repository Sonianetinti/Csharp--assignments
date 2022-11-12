using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    internal class Q5
    {
        public class Employee
        {
            int ID;
            string Name;
            string Company;
            static void Main(string[] args)
            {
                bool isExist = false;

                List<Employee> Employees = new List<Employee>()
        {
             new Employee {ID=101,   Name="soni"  , Company="Capgemini"},
             new Employee {ID=102,   Name="henry  "   , Company="infosys"},

        };


                Employee Emp1 = new Employee() { ID = 101, Name = "john", Company = "infosys" };

                isExist = Employees.AsEnumerable().Contains(Emp1);

                if (isExist == true)
                    Console.WriteLine("Emp1 exists in the Employees list");
                else
                    Console.WriteLine("Emp1 does not exist in the Employee's list");
                Console.ReadLine();
            }
        }
    }
}