using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question16
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray();           
            int j = 0;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                charArray[j++] = word[i];
            }
            Console.Write($"The reverse of '{word}' is :");
            Console.Write(charArray);
        }
    }
}
