using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay6
{
    internal class Question5
    {
        static void Main(string[] args)
        {
            /* Write an executable program in C# that will hold the employee code and employee names available in 
            an Organization using Collections.When the data is displayed it should be in a sorted manner.Choose an 
            appropiate type of Collection. */
            SortedList<int, string> obj = new SortedList<int, string>();
            obj.Add(1000, "Anna");
            obj.Add(1006, "Midhun");
            obj.Add(1004, "Akhil");
            obj.Add(1002, "Hajira");
            obj.Add(1005, "Bincy");
            obj.Add(1001, "Keerthi");
            obj.Add(1003, "Libin");
            foreach (var item in obj.Keys)
            {
                Console.WriteLine($"Employee code : {item} Employee names : {obj[item]}");
            }
        }
        
    }
}
