using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "--------------------\n" +
                "Fun With Class Types\n" +
                "--------------------\n"
            );
            
            // Allocate and Configure a Car object
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Speed up the car a few times and print out the new state
            for(int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
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
