using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question5
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            string str2 = "The quick brown fox jumps over the lazy dog.";
            string str3 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            Console.WriteLine(str.Equals(str2));
            Console.WriteLine(str.Equals(str3));
        }
    }
}
