using Assignment3;
using System;

namespace Assignment3
{
    public class EmployeeManagementSystem : Iprintable
    {
        public int Salary;
        public void Print()
        {
            Console.WriteLine("enter the details of employee:");
        }

    }
    public class Manager : EmployeeManagementSystem
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;




        public void Calculate()
        {
            PetrolAllowance = 8 * (Salary / 100);
            FoodAllowance = 13 * (Salary / 100);
            OtherAllowance = 3 * (Salary / 100);

            Console.WriteLine("GROSS SALARY OF MANAGER = {0}", Salary + PetrolAllowance + FoodAllowance + OtherAllowance);
        }
        public void CalculateSalary()
        {
            Console.WriteLine("NET SALARY OF MANAGER = {0}", Salary);
        }


    }
    public class MarketingExecutive : EmployeeManagementSystem
    {
        private int KiloMeterTravel;
        private int TourAllowances;
        private int TelephoneAllowances;




        public void Calculate()
        {
            Console.WriteLine("enter kilomter travel");
            KiloMeterTravel = Convert.ToInt32(Console.ReadLine());
            TourAllowances = KiloMeterTravel * 5;
            TelephoneAllowances = 1000;

            Console.WriteLine("gross Salary of marketing executive: {0}", KiloMeterTravel + TourAllowances + TelephoneAllowances);
        }
        public void CalculateSalary()
        {
            Console.WriteLine("net salary of marketing exective:{0}", +Salary);
        }
    }
}
interface Iprintable
{
    void Print();
}

public class Program
{
    public static void Main()
    {

        EmployeeManagementSystem emp = new EmployeeManagementSystem();
        emp.Print();
        Manager manager = new Manager();
        manager.Salary = 50000;
        manager.Calculate();
        manager.CalculateSalary();

        MarketingExecutive ME = new MarketingExecutive();
        ME.Salary = 30000;
        ME.Calculate();
        ME.CalculateSalary();
        Console.ReadKey();
    }

}

