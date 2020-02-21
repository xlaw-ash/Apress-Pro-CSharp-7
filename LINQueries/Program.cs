using System;
using System.Linq;
using Templates;
using System.Collections.Generic;

namespace LINQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTemplate.Header("Language Integrated Queries (LINQ)");            
            DisplayTemplate.Header("LINQ to Objects");

            string[] games = { "Skyrim", "Uncharted 4", "The Last Of Us", "The Witcher III", "Control" };
            IEnumerable<string> subset = from game in games where game.Contains(" ") orderby game select game;
            foreach (string game in subset) { Console.WriteLine(game); }
            Console.WriteLine();

            // Another way is to use extensions
            subset = games.Where(game => game.Contains("The")).OrderBy(game => game).Select(game => game);
            foreach (string game in subset) { Console.WriteLine(game); }
            Console.WriteLine();

            // Instead of using IEnumerable, we can also use var
            var sorted = games.OrderBy(game => game).Select(game => game);
            foreach (string game in sorted) { Console.WriteLine(game); }
            Console.WriteLine();

            // LINQ queries are dynamic. Which means, there is no need to define LINQ queries again and again.
            games[1] = "God Of War";
            foreach (string game in sorted) { Console.WriteLine(game); }
            Console.WriteLine();

            // Data from LINQ queries can be stored in a collection.
            int[] numbers = { 1, 2, 5, 7, 8, 23, 12, 45, 76, 32, 124, 6, 53, 4, 34 };
            int[] evenNumbers = numbers.Where(number => number % 2 == 0).OrderBy(number => -number).Select(number => number).ToArray<int>();
            foreach(int number in evenNumbers) { Console.Write(number + " "); }
            Console.WriteLine();
            // Note that values do not change after storing in a collection.
            numbers[1] = 25;
            foreach (int number in evenNumbers) { Console.Write(number + " "); }
            Console.WriteLine("\n");

            // LINQ queries over objects of custom classes
            List<Student> students = new List<Student>()
            {
                new Student(101, "Mark", 10),
                new Student(105, "John", 12),
                new Student(104, "Jack", 10),
                new Student(102, "Simon", 12),
                new Student(103, "Phillip", 10),
            };
            Student[] tenthGradeStudents = students.Where(student => student.Grade == 10).OrderBy(student => student.RollNumber).Select(student => student).ToArray<Student>();
            foreach(Student student in tenthGradeStudents) { Console.WriteLine(student.Name); }
            Console.WriteLine();

            // In above example, I am creating array of Student, even though I am just printing names.
            // This is very inefficient as Student array takes a lot more space than a string array.
            // A better way is to retrieve only required data.
            string[] tenthGradeStudentsNames = students.Where(student => student.Grade == 10).OrderBy(student => student.RollNumber).Select(student => student.Name).ToArray<string>();
            foreach (string student in tenthGradeStudentsNames) { Console.WriteLine(student); }
            Console.WriteLine();          

            DisplayTemplate.Footer();
        }
    }
}
