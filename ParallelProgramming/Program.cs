using System;
using System.Threading;
using Templates;

namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTemplate.Header("Multi-Threading Programming");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] flowers = { "Jasmine", "Rose", "Sunflower", "Lotus", "Lily" };

            Thread numberThread = new Thread(new ParameterizedThreadStart(printNumbers));
            Thread flowerThread = new Thread(new ParameterizedThreadStart(printFlowers));
            numberThread.Start(numbers);
            flowerThread.Start(flowers);

            DisplayTemplate.Footer();
        }

        static void printNumbers(object obj)
        {
            int[] numbers = (int[])obj;
            foreach(int number in numbers) { Console.WriteLine(number); }
        }

        static void printFlowers(object obj)
        {
            string[] flowers = (string[])obj;
            foreach(string flower in flowers) { Console.WriteLine(flower); }
        }
    }
}
