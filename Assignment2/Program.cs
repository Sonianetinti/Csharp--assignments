﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public void GetInput()
        {
            Console.WriteLine("enter the employee no:");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee name:");
            EmpName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the employee salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void Calc()
        {
            if (Salary <= 5000)
            {
                HRA = 10 * (Salary / 100);
                TA = 5 * (Salary / 100);
                DA = 15 * (Salary / 100);
            }
            else if (Salary < 10000)
            {
                HRA = 15 * (Salary / 100);
                TA = 10 * (Salary / 100);
                DA = 20 * (Salary / 100);


            }
            else if (Salary < 15000)
            {
                HRA = 20 * (Salary / 100);
                TA = 15 * (Salary / 100);
                DA = 25 * (Salary / 100);

            }
            else if (Salary < 20000)
            {
                HRA = 25 * (Salary / 100);
                TA = 20 * (Salary / 100);
                DA = 30 * (Salary / 100);

            }
            else
            {
                HRA = 30 * (Salary / 100);
                TA = 25 * (Salary / 100);
                DA = 35 * (Salary / 100);
            }
            GrossSalary = Salary + HRA + TA + DA;


        }
        public void CalculateSalary()
        {
            PF = 10 * (GrossSalary / 100);
            TDS = 18 * (GrossSalary / 100);
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void Display()
        {
            Console.WriteLine("employee no:" +EmpNo);
            Console.WriteLine("employee name:"+ EmpName);
            Console.WriteLine("employee salary:"+Salary);
            Console.WriteLine("House rent allowances:"+ HRA);
            Console.WriteLine("traveling allownces:"+ TA);
            Console.WriteLine("DA:"+DA);
            Console.WriteLine("TDS:"+TDS);
            Console.WriteLine("NetSalary:"+NetSalary);
            Console.WriteLine("Gross Salary:"+GrossSalary);
        }
        public static void Main()
        {
            Employee emp = new Employee();
            emp.GetInput();
            emp.Calc();
            emp.CalculateSalary();
            emp.Display();
            Console.ReadKey();

        }
          
    }
}
