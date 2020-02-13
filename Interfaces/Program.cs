using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "-------------------\n" +
                "Fun with Interfaces\n" +
                "-------------------\n"
            );

            // Customer wants a decaf cold coffee with ice with 2 spoons sugar
            Coffee coffee = new Coffee();
            coffee.Milk = 150;
            coffee.Water = 50;
            coffee.Sugar = 2;
            coffee.Hot = false;
            coffee.IsDecaf = true;
            coffee.Caffeine = 0.5;
            coffee.Ice = true;
            coffee.Make();

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
