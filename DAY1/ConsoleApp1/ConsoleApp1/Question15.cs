using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int length = 0;
            for (int i = 0; i < word.Length; i++)
            {
                length++;
            }
            Console.WriteLine("Length of the word is : " + length);
        }
    }
}
