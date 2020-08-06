using System;

namespace Chapter_5
{
    class A
    {
        private int[] numbers = new int[5];
        public int this[int index]
        {
            get
            {
                Console.WriteLine("The Get accessor of the base class has been called.");
                return numbers[index];
            }
            set
            {
                Console.WriteLine("The Set accessor of the base class has been called.");
                numbers[index] = value;
            }
        }
    }

    class B : A { }

    public class Order
    {
        private string[] productCodes = new string[5];
        public string this[int index]
        {
            get
            {
                return productCodes[index];
            }
            set
            {
                productCodes[index] = value;
            }
        }
    }


    class Base
    {
        protected int _id;
        public virtual int Id
        {
            get
            {
                Console.WriteLine("Get accessor of the Base class called."); return _id;
            }
            set
            {
                _id = value; Console.WriteLine("Set accessor of the Base class called.");
            }
        }
    }
    class Derived : Base
    {
        public override int Id
        {
            get
            {
                Console.WriteLine("Get accessor of the Derived class called."); return _id;
            }
            set
            {
                _id = value; Console.WriteLine("Set accessor of the Derived class called.");
            }
        }
    }

    //class BaseClass
    //{
    //    protected int[] numbers = new int[5];
    //    public virtual int this[int index]
    //    {
    //        get
    //        {
    //            Console.WriteLine("Get accessor of the base class called."); return numbers[index];
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set accessor of the base class called."); numbers[index] = value;
    //        }
    //    }
    //}

    //class DerivedClass : BaseClass
    //{
    //    public override int this[int index]
    //    {
    //        get
    //        {
    //            Console.WriteLine("Get accessor of the derived class called."); return numbers[index];
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set accessor of the derived class called."); numbers[index] = value;
    //        }
    //    }
    //}

    abstract class BaseClass
    {
        protected int[] numbers = new int[5];

        public abstract int this[int index]
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();
            obj[0] = 10; obj[1] = 20; obj[2] = 30; obj[3] = 40; obj[4] = 50;
        }
    }



            //A obj = new B();
            //obj[10] = 100;
            //Console.Read();


            Order order = new Order();
            order[0] = "P0001";
            order[1] = "P0002";
            order[2] = "P0003";


            Base b = new Derived();
            b.Id = 10;
            Console.Read();
       
    



            //Derived derived = new Derived();
            //derived.Id = 0;
            //Console.Read();












            //    Employee employee = new Employee();
            //    employee.EmployeeId = 1;
            //    employee.FirstName = "Joydip";
            //    employee.LastName = "Kanjilal";

            //    LogManager.FileName = "Log.txt";
            //    LogManager.Path = @"D:\Logs\";
        }
   }



    //class Base
    //{
    //    int _id;
    //    public int Id
    //    {
    //        get
    //        {
    //            Console.WriteLine("Get accessor of the Base class called.");
    //            return _id;
    //        }
    //        set
    //        {
    //            _id = value;
    //            Console.WriteLine("Set accessor of the Base class called.");
    //        }
    //    }
    //}
    //class Derived : Base
    //{
    //    //Members of the Derived class
    //}


    //class Employee
    //{
    //    public int EmployeeId { get; set; }

    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }
    //}

    //class Author
    //{
    //    internal int AuthorId { get; set; }

    //    internal string FirstName { get; set; }

    //    internal string LastName { get; set; }
    //}

    //class Author
    //{
    //    protected int AuthorId { get; set; }

    //    protected string FirstName { get; set; }

    //    protected string LastName { get; set; }
    //}

    //class LogManager
    //{
    //    public static string FileName { get; set; }
    //    public static string Path { get; set; }
    //}


    public abstract class Person
    {
        public abstract int Id
        {
            get;
            set;
        }
        public abstract string FirstName
        {
            get;
            set;
        }
        public abstract string LastName
        {
            get;
            set;
        }
    }

    public class Employee : Person
    {
        int _id;
        string _firstName;
        string _lastName;
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public override string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public override string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
