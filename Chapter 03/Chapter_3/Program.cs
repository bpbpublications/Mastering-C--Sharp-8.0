using System;

namespace Chapter_3
{
    //Constructor overloading
    class MyClass
    {
        public MyClass()
        {
            //Default constructor
        }
        public MyClass(int x)
        {
            //Constructor with one parameter. 
        }
        public MyClass(int x, int y)
        {
            //Constructor with two parameters.
        }
    }

    //Constructor chaining
    public class Base
    {
        public Base(int x)
        {
            //Default constructor
        }
    }

    class Derived : Base
    {
        public Derived() : base(0)
        {
            //Default constructor
        }
        public Derived(int x) : base(x)
        {
            //Constructor with one parameter. 
        }
        public Derived(int x, int y) : this(x)
        {
            //Constructor with two parameters.
        }
    }

    //Constructor chaining

    //public class Base
    //{
    //    public Base(int x)
    //    {
    //        Console.WriteLine("Base class constructor");
    //    }
    //}

    //public class Derived : Base
    //{
    //    public Derived() : base(0)
    //    {
    //        Console.WriteLine("Derived class constructor");
    //    }
    //}


    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public void Display()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Name: "+FirstName + " "+ LastName);
            Console.WriteLine("Address: "+Address);
        }
    }

    //public class MyClass
    //{
    //    public int x;
    //    public int y;

    //    public void Display()
    //    {
    //        //Code to display the values of x and y
    //    }
    //}

    //struct MyStruct
    //{
    //    int _x;
    //    public MyStruct(int x)
    //    {
    //        _x = x;
    //        Console.WriteLine("Constructor executed.");
    //        Console.WriteLine("The value is: "+_x);
    //    }
    //}

    //class MyClass
    //{
    //    static MyClass()
    //    {
    //        Console.WriteLine("Static Constructor executed.");
    //    }
    //}

    //class MyClass
    //{
    //    //public static string MyText { get; set; }
    //    static MyClass()
    //    {
    //        Console.WriteLine("Static Constructor executed.");
    //    }
    //    //public static int MyInteger
    //    //{
    //    //    get;set;
    //    //}
    //}

    //class MyClass
    //{
    //    public int x;
    //    public int y;
    //    static MyClass()
    //    {
    //        x = 0;
    //        y = 0;
    //    }
    //}

    //The following code will not compile

    //struct MyStruct
    //{
    //    public MyStruct()
    //    {

    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
