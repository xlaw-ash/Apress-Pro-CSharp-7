using System;
using System.Collections.Generic;
using Templates;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTemplate.Header("Lambda Expressions");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Print even numbers in the list.
            foreach(int number in numbers) { if(number % 2 == 0) { Console.Write(number + " "); } }
            Console.WriteLine();
            // Above method fits in one line, but it is still combination of foreach and if.
            // We can use FindAll method of List in combination with delegate.
            foreach (int number in numbers.FindAll(delegate(int number) { return (number % 2 == 0); })) { Console.Write(number + " "); }
            Console.WriteLine();
            // Note that name of variable in foreach, which is 'number', can be either same or different from the name of variable in delegate.

            // delegate is a little confusing and hard to remember. To make it short, let's use Lambda Expression.
            foreach (int number in numbers.FindAll(number => number % 2 == 0)) { Console.Write(number + " "); }
            Console.WriteLine();            

            DisplayTemplate.Footer();
        }
    }
}
