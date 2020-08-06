using System;

namespace Chapter_4_Example_4
{
    class Employee
    {
        private double basic;
        private double allowance;
        public void SetValues(double basic, double allowance)
        {
            this.basic = basic;
            this.allowance = allowance;
        }
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
            employee.SetValues(1000, 200);
            employee.DisplaySalary();
            Console.Read();
        }

    }
}
