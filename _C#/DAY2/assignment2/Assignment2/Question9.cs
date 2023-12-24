using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question9
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            // Animal names to look for
            string[] animalNames = { "fox", "dog" };

            // Split the sentence into words
            string[] words = sentence.Split(' ');

            Console.WriteLine("Split Sentences:");

            // Initialize variables to store the two parts
            string part1 = "";
            string part2 = "";
            foreach (string word in words)
            {
                // Check if the word is an animal name
                if (Array.Exists(animalNames, name => name.Equals(word, StringComparison.OrdinalIgnoreCase)))
                {
                    // Check if part1 is empty or if the last word in part1 is not an animal name
                    if (string.IsNullOrEmpty(part1) || !Array.Exists(animalNames, name => name.Equals(part1.Split(' ').Last(), StringComparison.OrdinalIgnoreCase)))
                    {
                        part1 += word + " ";
                    }
                    else
                    {
                        part2 += word + " ";
                    }
                }
                else
                {
                    part1 += word + " ";
                }
            }
            // Remove trailing spaces
            part1 = part1.Trim();
            part2 = part2.Trim();

            // Display the two parts
            Console.WriteLine($"Part 1: {part1}");
            Console.WriteLine($"Part 2: {part2}");
        }
    }
}
