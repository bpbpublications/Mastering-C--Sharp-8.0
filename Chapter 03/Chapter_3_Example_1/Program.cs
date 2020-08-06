using System;

namespace Chapter_3_Example_1
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public void Display()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Joydip";
            employee.LastName = "Kanjilal";
            employee.Address = "Hyderabad, India";
            employee.Display();

            Console.Read();
        }

    }
}
