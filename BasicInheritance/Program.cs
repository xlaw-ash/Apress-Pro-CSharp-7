using System;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "-----------------\n" +
                "Basic Inheritance\n" +
                "-----------------\n"
            );

            // Make a Car object and set Max Speed
            Car myCar = new Car(80);

            // Set the current speed and print it
            myCar.Speed = 60;
            Console.WriteLine($"Car Speed: {myCar.Speed} MPH");

            myCar.Speed = 90;
            Console.WriteLine($"Car Speed: {myCar.Speed} MPH");

            // Now make a Minivan object
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine($"MiniVan Speed: {myVan.Speed} MPH");

            Console.WriteLine
            (
                "\n--------------" +
                "\nEnd of Program" +
                "\n--------------"
            );
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
