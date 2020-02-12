using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "------------------\n" +
                "Exception Handling\n" +
                "------------------\n"
            );

            // Ask user to enter an integer
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            // If user does not enter integer, the program will break.
            // Add Try Catch block to prevent breaking of program.

            Console.Write("Enter an integer: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // If you do not know the exception, just use Exception class.
            // Exception is base class of all exceptions

            int zero = 0;
            try
            {
                num = 32 / zero; // Divide by zero is not allowed in compile time so zero variable is created. (32 / 0) is not allowed.
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine
            (
                "\n--------------" +
                "\nEnd of Program\n" +
                "--------------"
            );
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
