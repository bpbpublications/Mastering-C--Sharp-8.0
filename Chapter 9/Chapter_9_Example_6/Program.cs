using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9_Example_6
{
    public class InvalidInputException : System.Exception
    {
        public InvalidInputException() : base()
        {
        }
        public InvalidInputException(string message) : base(message)
        {
        }
        public InvalidInputException(string message, System.Exception inner) : base(message, inner)
        {
        }
        protected InvalidInputException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            try
            {
                if (j == 0)
                    throw new InvalidInputException
                   ("Number cannot be zero.");
            }
            catch (InvalidInputException ie)
            {
                Console.WriteLine(ie.Message);
            }

            Console.Read();
        }
    }
}
