using System;

namespace Chapter_4_Example_7
{
    class Employee
    {
        internal double basic;
        internal double allowance;

        protected internal void SetValues(double basic, double allowance)
        {
            this.basic = basic;
            this.allowance = allowance;
        }
        protected internal void DisplaySalary()
        {
            Console.WriteLine("The salary is: " + (basic + allowance));
        }
    }
    class SalesEmployee : Employee
    {
        public void Initialize(double basic, double allowance)
        {
            this.SetValues(basic, allowance);
        }
        public void Display()
        {
            this.DisplaySalary();
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
