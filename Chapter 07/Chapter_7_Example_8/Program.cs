using System;

namespace Chapter_7_Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] integerArray = { 1, 2, 3, 4, 5, 6,7, 8, 9 };
            Console.WriteLine("Displaying integers");
            Display(integerArray);

            char[] characterArray = { 'H', 'e', 'l', 'l', 'o', '!' };
            Console.WriteLine("\nDisplaying characters");
            Display(characterArray);

            Console.Read();
        }

        public static void Display<G>(G[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
