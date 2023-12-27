using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question14
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            Console.Write("Enter mark 10 marks");
            for (int i = 0; i < marks.Length; i++)
            {               
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = (double)total / marks.Length;

            int minMark = marks[0];
            int maxMark = marks[0];
            foreach (int mark in marks)
            {
                if (mark < minMark)
                    minMark = mark;
                if (mark > maxMark)
                    maxMark = mark;
            }
            // Display total, average, minimum, and maximum marks
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Minimum Mark: {minMark}");
            Console.WriteLine($"Maximum Mark: {maxMark}");

            // Display marks in ascending order
            Console.WriteLine("Marks in Ascending Order:");
            Array.Sort(marks);
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();

            // Display marks in descending order
            Console.WriteLine("Marks in Descending Order:");
            Array.Reverse(marks);
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
        }
        
    }
}
