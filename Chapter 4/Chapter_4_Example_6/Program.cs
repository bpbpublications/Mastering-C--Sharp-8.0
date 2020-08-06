using System;

namespace Chapter_4_Example_6
{
    class Employee
    {
        internal double basic;
        internal double allowance;

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
            employee.basic = 1000;
            employee.allowance = 200;
            employee.DisplaySalary();
            Console.Read();
        }
    }
}
