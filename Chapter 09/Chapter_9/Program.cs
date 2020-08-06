using System;

namespace Chapter_9
{
    public class LoginException : Exception
    {
        public LoginException()
        {
        }

        public LoginException(string message)
            : base(message)
        {
        }

        public LoginException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class WorkflowException : Exception
    {
        public WorkflowException()
        {
        }

        public WorkflowException(string message)
            : base(message)
        {
        }

        public WorkflowException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }


     //try
     //{
     //     throw new Exception
     //    ("Throwing exceptions this way, is expensive.");
     //}
     //catch (Exception ex)
     //{
     //   Console.WriteLine(ex.Message);
     //}

    
        //int i = 10, j = 10;

        //try
        //{
        //    throw new Exception("Throwing exceptions this way, is expensive");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        //finally
        //{
        //    Console.WriteLine("Inside Main()");
        //}

        //SqlConnection connection;

        //try
        //{
        //    /*Write code here to connect to the database using a connection string */
        //    connection.Open();
        //}

        //catch (Exception ex)
        //{
        //    //Write code here to handle exception
        //}

        //finally
        //{
        //    connection.Close(); //Code to cleanup resources should be
        //                        // written inside the finally block
        //}

        //int i = 10, j = 0;

        //try
        //{
        //    int z = i / j;
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error occured: "+ex.Message);
        //}
    
}
