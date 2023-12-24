using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question10
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            // Animal names to look for
            string[] animalNames = { "fox", "dog" };

            Console.WriteLine("Animal Names:");

            // Use LINQ to filter and print animal names
            var matchingAnimalNames = animalNames
                .Where(animalName => sentence.IndexOf(animalName, StringComparison.OrdinalIgnoreCase) >= 0);

            foreach (var animalName in matchingAnimalNames)
            {
                Console.WriteLine(animalName);
            }
        }
    }

}

