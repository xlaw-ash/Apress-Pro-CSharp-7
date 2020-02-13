using System;
using System.Collections.Generic;
using Templates;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instead of copying and pasting the header and footer of program all the time
            // Using a template which is defined in DisplayTemplate class of Templates namespace
            // This reduces redundant writing of code. To use this class, add Templates project as a reference.

            DisplayTemplate.Header("Fun With Collections");

            // There are many in-built collections.
            // Use Generic collections to avoid issues.

            // List is a dynamic array. The size can increase.
            Console.WriteLine("Integer type List Example");
            List<int> intArr = new List<int>();
            for(int i = 0; i < 10; i++) { intArr.Add(i); }
            intArr.ForEach(num => Console.Write(num + " ")); // List can iterate over elements and use lambda expression.
            Console.WriteLine();
            intArr.RemoveAt(5);
            intArr.ForEach(num => Console.Write(num + " "));
            Console.WriteLine("\n");

            // You can also make a General list. This list contains int, string and double.
            List<object> genArr = new List<object>();
            genArr.Add(21);
            genArr.Add("Mark");
            genArr.Add(0.5);
            Console.WriteLine("General List Example");
            genArr.ForEach(num => Console.WriteLine(num + " : " + num.GetType()));
            Console.WriteLine();

            // An example of Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack Example");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

            // An example of Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Queue Example");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            // An example of Dictionary. Dictionary is a key-value pair. Key must be unique.
            Console.WriteLine("Dictionary Example");
            Dictionary<int, string> courses = new Dictionary<int, string>() { [101] = "Math", [102] = "Science" };
            courses.Add(103, "Computers");
            courses.Add(104, "History");

            // Iterate using keys
            foreach(int key in courses.Keys) { Console.WriteLine(key + " : " + courses[key]); }
            Console.WriteLine();

            DisplayTemplate.Footer();
        }
    }
}
