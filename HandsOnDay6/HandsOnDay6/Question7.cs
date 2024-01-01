using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay6
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string School { get; set;}

        public void Display()
        {
            ArrayList list= new ArrayList();
            Console.WriteLine("Enter student id");
            list.Add(Id=int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter student name");
            list.Add(Name=Console.ReadLine());
            Console.WriteLine("Enter student age");
            list.Add(Age=int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter School");
            list.Add(School=Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter student details");     
                Console.WriteLine($"ID : {Id} Name : {Name} Age : {Age} School : {School}");
        }
    }
    internal class Question7
    {
        public static void Main(string[] args)
        {
            /*. Create a class with name student and store all the student details in an ArrayList  
             * and Display the Details.*/
            Student student = new Student();
            student.Display();
            
        }
    }
}
