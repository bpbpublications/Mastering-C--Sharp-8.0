using System;
using System.Collections.Generic;

namespace Chapter_4
{
    //public class Association
    //{
    //    public void SomeMethod(SomeClass someObj)
    //    {
    //        someObj.DoSomeWork();
    //    }
    //}

    //Aggregation relationship
    public class Library
    {
        private List<Student> members = new List<Student>();
    }
    class Student
    {
        int rollNo;
        private string firstName;
        private string lastName;
        private string standard;
        private string section;

        //Other members of the Student class
    }

    //Composition
    public class Building
    {
        private List<Room> rooms = new List<Room>(); //A building comprises of several rooms
    }

    class Room
    {
        int floor;
        string flatNumber;
    }

    class Base
    {
        //Members of the class Base
    }
    class Dervied : Base
    {
        //Members of the class Derived
    }

    class A
    {
        //Members of the class A
    }
    class B : A
    {
        //Members of the class B
    }
    class C : B
    {
        //Members of the class C
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
