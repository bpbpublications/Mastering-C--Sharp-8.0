using System;

namespace Chapter_4_Example_3
{
    class Employee
    {
        public double basic;
        public double allowance;

        public void DisplaySalary()
        {
            Console.WriteLine("The salary is: " + (basic + allowance));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.basic = 1000;
            employee.allowance = 200;
            employee.DisplaySalary();
            Console.Read();
        }

    }
}
