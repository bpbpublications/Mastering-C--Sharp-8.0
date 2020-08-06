using System;

namespace Chapter_14_Example_2
{
    public class Order
    {
        int _id;
       public Order(int Id)
        {
            _id = Id;
        }
        public Order With(int Id = 1) => new Order(Id);
    }

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
