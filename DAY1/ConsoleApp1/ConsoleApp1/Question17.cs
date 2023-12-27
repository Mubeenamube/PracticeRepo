using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();
            if(word1.Equals(word2))
            {
                Console.WriteLine("Both words are the same.");
            }
            else
                Console.WriteLine("The words are different.");
        }
    }
}
