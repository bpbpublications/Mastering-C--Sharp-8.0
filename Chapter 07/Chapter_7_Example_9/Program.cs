using System;

namespace Chapter_7_Example_9
{
    public class GenericStack<GS>
    {
        const int size = 10;
        private readonly GS[] dataRegister = new GS[size];
        private int counter = 0;
        public void Push(GS x)
        {
            if (counter < size)
                dataRegister[counter++] = x;
        }
        public GS Pop()
        {
            return dataRegister[--counter];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> integerStack = new GenericStack<int>();
            integerStack.Push(10);
            Console.WriteLine(integerStack.Pop());
            Console.Read();
        }
    }
}
