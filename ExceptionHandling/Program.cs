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

            // C# provides a lot of in-built exceptions and you can throw your own exception message as per need of application.            
            
            Console.Write("Enter a multiple of 10: ");
            // Instead of using if-else statements, we can use custom exception message
            try { num = int.Parse(Console.ReadLine()); PrintMultipleOfTen(num); }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // This was is alright, but it doesn't provide a good understanding of exception.
            // We can also create custom exception class which inherits ApplicationException class.
            // Suppose your application accepts only VIBGYOR colors. (Violet, Indigo, Blue, Green, Yellow, Orange, Red)
            try
            {
                Console.Write("Enter a color: ");
                string color = Console.ReadLine();
                PrintColor(color);
            }
            catch(ColorInRainbowException e)
            {
                Console.WriteLine(e.Message);
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

        static void PrintColor(string color)
        {
            ColorInRainbowException e = new ColorInRainbowException(color);
            string[] colors = new string[] { "violet", "indigo", "blue", "green", "yellow", "orange", "red" };
            if (!Array.Exists<string>(colors, x => x == color))
            {
                throw e;
            }
            else
            {
                Console.WriteLine(color);
            }
        }

        static void PrintMultipleOfTen(int num)
        {
            if(num % 10 != 0)
            {
                throw new Exception(message: $"Error: {num} is not a multiple of 10");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
