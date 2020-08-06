using System;

namespace Chapter_4_Example_5
{
    class Employee
    {
        protected double basic;
        protected double allowance;
    }

    class SalesEmployee : Employee
    {
        public void Initialize(double basic, double allowance)
        {
            this.basic = basic;
            this.allowance = allowance;
        }
        public void Display()
        {
            Console.WriteLine("The salary is: " + (basic + allowance));
        }

        //Other members
    }

    class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee employee = new SalesEmployee();
            employee.Initialize(1000, 200);
            employee.Display();

            Console.Read();
        }
    }
}
