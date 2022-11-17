using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{

    public class Employee
    {

        public int employeeId;
        public string firstName;
        public string lastName;
        public string title;
        public DateTime dob;
        public DateTime doj;
        public string city;
        public Employee(int employeeId, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.dob = dob;
            this.doj = doj;
            this.city = city;

        }
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public DateTime DOJ
        {
            get { return doj; }
            set { doj = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984 , 11 , 16), new DateTime(2011 ,6 , 8), "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984,8, 20), new DateTime(2012 ,7 ,7), "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987,11 , 14), new DateTime(2015 , 4 , 12), "Pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990 , 6 , 3), new DateTime(2016 , 2 , 2), "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991 ,3 , 8), new DateTime(2016,2 ,2), "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989 , 11 , 7), new DateTime(2014 , 8 ,8), "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989 , 12 ,2), new DateTime(2015 , 6 , 1), "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993 ,11 , 11), new DateTime(2014 , 11 , 6), "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992 , 8 , 12), new DateTime(2014,12, 3), "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991 ,4 ,12), new DateTime(2016, 1, 2), "Pune"));

            Console.WriteLine("--------------display all details of employees--------------");
            IEnumerable<Employee> query = from emp in empList select emp;
            foreach (var em in query)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("---------employee details whose location is not mumbai---------");
            
            IEnumerable<Employee> query2 = from emp in empList where emp.City!="Mumbai" select emp;
            foreach(var em in query2)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine() ;
            Console.WriteLine("---------employee details whose title is AsstManager----------");
            IEnumerable<Employee> query3 = from emp in empList where emp.Title=="AsstManager" select emp;
            foreach (var em in query3)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("-------employee details whose last name starts with 's'-------");
            IEnumerable<Employee> query4 = from emp in empList where emp.LastName.StartsWith('S'+"") select emp;
            foreach (var em in query4)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("------employee details who joined before 2015-------");
            IEnumerable<Employee> query5= from emp in empList where emp.DOJ< (new DateTime(2015,1,1)) select emp;
            foreach (var em in query5)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("---------employee details whose date of birth is after 1/1/1990-------");   
            IEnumerable<Employee> query6 = from emp in empList where emp.DOB > (new DateTime(1990, 1, 1)) select emp;
            foreach (var em in query6)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }

            Console.WriteLine();
            Console.WriteLine("-------------employee details whose designation is Consultant and Assosciate----------");
           
            IEnumerable<Employee> query7 = from emp in empList where (emp.Title=="Consultant")||(emp.Title=="Associate") select emp;
            foreach (var em in query7)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("---------total number of employees------------");
            int result=empList.Count();
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("---------Total number of Employees whose location is Chennai----------");
            int resCity = (from emp in empList where emp.City=="Chennai" select emp).Count();
            Console.WriteLine(resCity);
            Console.WriteLine();
            Console.WriteLine("--------Highest employeeId value---------");
            int maxid = empList.Max(em=>em.EmployeeId);   
            Console.WriteLine(maxid);
            Console.WriteLine();
            Console.WriteLine("------employees who joined after 2015/1/1----------");
            IEnumerable<Employee> query9 = from emp in empList where emp.DOJ > (new DateTime(2015,1,1)) select emp;
            foreach (var em in query9)
            {
                Console.WriteLine("employee details:{0},{1},{2},{3},{4},{5},{6}", em.EmployeeId, em.FirstName, em.LastName, em.Title, em.DOB, em.DOJ, em.City);
            }
            Console.WriteLine();
            Console.WriteLine("-----------total number of employees whose designation is not Associate----------");
            int resTitle = (from emp in empList where emp.Title != "Associate" select emp).Count();
            Console.WriteLine(resTitle);

            Console.WriteLine();
            Console.WriteLine("--------Employees based on City--------");
            int cityb = (from emp in empList group emp by emp.City).Count();
            Console.WriteLine(cityb);
            
            Console.WriteLine();
            Console.WriteLine("---------Employees based on city and title-------------");
            int ResCT = (from emp in empList group emp by ( emp.City,emp.Title)).Count();
            Console.WriteLine(ResCT);

            Console.WriteLine();
            Console.WriteLine("--------------Employee who is youngest in the list----------");
            var youngest = empList.Select(em => em.DOB);
            Console.WriteLine(youngest.Min());








            Console.ReadKey();

        }

    }
}

