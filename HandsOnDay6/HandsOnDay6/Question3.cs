using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay6
{
    internal class Question3
    {
        static void Main(string[] args)
        {
            //Accept 10 numbers and sort the data in ascending order and display it. 
            List<int> list = new List<int>();
            Console.WriteLine("Enter 10 numbers");
            for(int i = 1;i<=10;i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Sorted numbers in ascending order:");
            list.Sort();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
