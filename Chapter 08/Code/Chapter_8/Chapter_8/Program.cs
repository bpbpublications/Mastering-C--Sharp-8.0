using System;

namespace Chapter_8
{
    public static class TestExtensions
    {
        public static string FirstLetterShouldBeInUpperCase(this string s) { return string.Empty; }
        public static string Pluralize(this string s) { return string.Empty; }
    }

    public static class ObjectExtensions
    {
        public static int WordCount(this object text)
        {
            return text.ToString().Split(new char[] { ' ', '.', ',' }).Length;
        }
    }
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string text)
        {
            return text.ToUpper().Equals(text) ? true : false;
        }
        public static int WordCount(this string text)
        {
            return text.Split(new char[] { ' ', '.', ',' }).Length;
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsGreaterThan(this int i, int j)
        {
            return i > j;
        }
        public static bool IsEven(this int i)
        {
            return (i % 2) == 0 ? true : false;
        }
    }

    class Program
    {
        public delegate void MulticastDelegate(string someText);
        public delegate TResult Func<in T, out TResult>(T arg);
        static void SomeMethod(string text)
        {
            Console.WriteLine(text);
        }

        static void MethodA(string text)
        {
            Console.WriteLine("Inside method A.\t"+text);
        }

        static void MethodB(string text)
        {
            Console.WriteLine("Inside method B.\t"+text);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        Func<int> getMilliseconds = delegate ()
        {
            return DateTime.Now.Millisecond;
        };

        static void DisplayMessage(string text)
        {
            Console.WriteLine(text);
        }

        static bool IsEven(int i)
        {
            return (i % 2) == 0 ? true: false;
        }

        static void Main(string[] args)
        {
            string text = "This is an example text";
            int ctr = text.WordCount();

            //int ctr = "This is a line of text.".WordCount();


            //Predicate<int> isNumberEven = IsEven;
            //bool result = isNumberEven(1);
            //Console.WriteLine(result);

            int i = 1;
            bool isEven = i.IsEven();


            int a = 10, b = 5;
            bool isGreater = a.IsGreaterThan(b);

            //Predicate<string> isUpperCase = s => s.Equals(s.ToUpper());
            //bool result = isUpperCase("This text is in mixed case.");

            ////Predicate<int> isNumberEven = delegate (int i) { return (i % 2) == 0 ? true : false; };
            ////bool result = isNumberEven(1);

            //Action<string> actionDelegate = delegate (string text)
            //{
            //    Console.WriteLine(text);
            //};

            //actionDelegate("Hello World!");


            Action<string> action = DisplayMessage;
            action("Hello World!");

            Func<int, int, int> math = Add;
            int result = math(1, 2);
            Console.WriteLine(result);

            //MulticastDelegate delegateAObj = new MulticastDelegate(MethodA);
            //MulticastDelegate delegateBObj = new MulticastDelegate(MethodB);
            //MulticastDelegate multicastDelegate = (MulticastDelegate)Delegate.Combine(delegateAObj, delegateBObj);
            //multicastDelegate.Invoke("This is a multicast delegate");
            Console.Read();
        }
    }
}
