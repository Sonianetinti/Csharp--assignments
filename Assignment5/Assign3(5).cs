using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignment5
{
    public class employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        
     
    }
    public  class Assign3_5_
    {
        public static void Main()
        {

            List<employee> employeeList = new List<employee>();
            employeeList.Add(new employee
            {
                Name = "jimmy", 
                Age = 23,
                Salary = 3456
            });
            employeeList.Add(new employee
            {
                Name = "kittu",
                Age =34,
                Salary = 84674
            });

            foreach (var data in employeeList)
            {
                Console.WriteLine("name of the employee");
              Console.WriteLine(data.Name);
                Console.WriteLine("age of employee");
              Console.WriteLine(data.Age);
                Console.WriteLine("salary of employee:");
                Console.WriteLine(data.Salary);

                Console.WriteLine("total no of employees");
                Console.WriteLine(employeeList.Count);
            }

            Console.ReadKey();
        }
    }
}
