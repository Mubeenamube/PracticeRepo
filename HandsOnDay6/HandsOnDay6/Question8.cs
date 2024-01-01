using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandsOnDay6
{

    class Employee
    {
        public string name { get; set; }
        public string description { get; set; }
    }
    internal class Question8
    {

        public static void Main(string[] args)
        {
            Employee obj=new Employee();
            /*Employee details name and designation is entered by the user in random order. It is desired to 
            maintain a list  such that all the employees with the same designation must be kept together.
            Also, the list must have Program Managers first, then Project Manager, Team  Lead, 
            Senior Programmer and Junior Programmer in that order. Display the list after all entry is done.*/
            try
            {               
                List<string> list = new List<string>();
                list.Add("Program Manager");
                list.Add("Project Manager");
                list.Add("Team Lead");
                list.Add("Senior Programmer");
                list.Add("Junior Programmer");
                Dictionary<string,string> map = new Dictionary<string,string>();
                Console.WriteLine("enter name and description");
                for (int i = 0; i <3; i++)
                {
                    map.Add(obj.name=Console.ReadLine(),obj.description=Console.ReadLine());
                   foreach (string s in list)
                    {
                        if(s==obj.description)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
