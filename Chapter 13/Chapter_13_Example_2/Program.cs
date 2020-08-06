using System;

namespace Chapter_13_Example_2
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class PartTimeEmployee : Employee
    {
        public double Basic { get; set; }
    }

    public class FullTimeEmployee:Employee
    {
        public double Basic { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "This is a test message to demonstrate how pattern matching works.";

            if (obj is string str)
            {
                Console.WriteLine(str);
            }

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.Id = 1;
            partTimeEmployee.FirstName = "Joydip";
            partTimeEmployee.LastName = "Kanjilal";

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            partTimeEmployee.Id = 1;
            partTimeEmployee.FirstName = "Joydip";
            partTimeEmployee.LastName = "Kanjilal";

            if (partTimeEmployee is Employee)
                Console.WriteLine("Employee");

            Console.Read();
        }
    }
}
