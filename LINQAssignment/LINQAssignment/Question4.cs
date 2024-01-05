using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    internal class Question4
    {
        static void Main(string[] args)
        {
            /*For the previous exercise, write a LINQ query that displays the 
              details grouped by the month in the descending order of the order date.*/
            List<Order> list = new List<Order>()
            {
                new Order(100,"Pen",new DateTime(2023,09,05),2),
                new Order(101,"Book",new DateTime(2023,10,01),5),
                new Order(102,"Pencil",new DateTime(2023,08,12),6),
                new Order(103,"phone",new DateTime(2023,12,10),1),
                new Order(104,"mouse",new DateTime(2023,10,02),3),
                new Order(105,"Paper",new DateTime(2023,11,28),10),
            };
            
            var result2 = from Order order in list
                          orderby order.OrderDate descending
                          group order by order.OrderDate.Month;

            foreach (var f in result2)
            {           
                Console.Write("Order of the Month "+f.Key+" ");
                foreach (var n in f)
                    Console.Write(n.OrderName);
                Console.WriteLine();
            }
        }
    }
}
