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

            // Sometimes, a process is running in try block and due to some exception, the program exits try block without closing that process.
            // For example, reading a file in try block. If some exception occurs, the file will remain open.
            // File will not close until it is explicitly closed with proper method.
            // To avoid this situation, finally is used. Let's see a simple example.
            // Car is moving at certain speed. If car speed crosses maximum speed, the engine breaks.

            Car myCar = new Car(60, true);
            try
            {                
                for(int i = 0; i <= 5; i++) { myCar.Speed += 10; }
                Console.WriteLine("You have reached your destination.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Radio of myCar: {((myCar.Radio) ? "On" : "Off")}");
            // Note that Car's radio is on. This is a problem because Car's radio should automatically switch off when car breaks.
            // Use finally to handle this problem.            
            myCar.Speed = 60;
            myCar.Radio = true;
            try
            {
                for (int i = 0; i <= 5; i++) { myCar.Speed += 10; }
                Console.WriteLine("You have reached your destination.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.Radio = false;
            }
            Console.WriteLine($"Radio of myCar: {((myCar.Radio) ? "On" : "Off")}");
            // Car's radio is now off. finally is used when a process must happen, irrespective of exception.

            // Sometimes, user wants an exception only when a certain condition is met.
            // Suppose car has a Safe mode which doesn't let it break.

            myCar.Speed = 60;
            myCar.Radio = true;
            myCar.Safe = true;

            try
            {
                for (int i = 0; i <= 5; i++) { myCar.Speed += 10; }
                Console.WriteLine("You have reached your destination.");
            }
            catch (Exception e) when (myCar.Safe) // When car is in Safe mode, execute this message.
            {                
                Console.WriteLine("You have reached your destination.");
                Console.WriteLine("You are lucky that car did not break due to Safe mode. Please drive carefully next time.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.Radio = false;
            }

            // This example of when is not a good one, but remember that when clause is used to execute exception statements in certain condition.


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
