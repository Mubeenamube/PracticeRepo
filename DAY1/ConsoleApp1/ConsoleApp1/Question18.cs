using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            bool flag=false;
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - 1 - i])
                {
                    flag = true; // Not a palindrome
                }
            }
            if(flag)
            {
                Console.WriteLine($"{word} is not a palindrome.");
            }
            else
                Console.WriteLine($"{word} is a palindrome.");
        }
    }
}
