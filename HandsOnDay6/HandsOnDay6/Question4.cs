using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay6
{
    internal class Question4
    {
        static void Main(string[] args)
        {
            try
            {
                //Write an Arraylist that will hold the names of all students and display them in descending order. 
                ArrayList list = new ArrayList();
                Console.WriteLine("Enter name of students");
                for(int i = 0;i<5;i++)
                    list.Add(Console.ReadLine());
                Console.WriteLine();
                list.Sort();
                list.Reverse();
                Console.WriteLine("sorted list");
                foreach (string i in list)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
