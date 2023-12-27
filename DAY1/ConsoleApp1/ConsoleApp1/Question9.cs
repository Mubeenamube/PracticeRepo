using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question9
    {
        static void Main(string[] args)
        {
            int n = 40;
            int first = 0, second = 1, next;

            Console.Write($"{first} {second} ");

            for (int i = 2; ; i++)
            {
                next = first + second;
                if (next > n)
                    break;

                Console.Write($"{next} ");

                first = second;
                second = next;
            }
            }
    }
}
