using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Question15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the home directory of Tomcat server: ");
            string tomcatHome = Console.ReadLine();

            // Combine the entered path with the additional path to WebApps/MyApps/Images
            string imagePath = $@"{tomcatHome}\WebApps\MyApps\Images";

            // Display the resulting path in the console
            Console.WriteLine($"Updated path: {imagePath}");
        }
    }
}
