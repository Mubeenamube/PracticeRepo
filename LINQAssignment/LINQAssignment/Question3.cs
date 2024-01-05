using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class Order
    {
        public Order(int orderID, string orderName, DateTime orderDate, int orderQnty)
        {
            OrderID = orderID;
            OrderName = orderName;
            OrderDate = orderDate;
            OrderQnty = orderQnty;
        }

        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQnty { get; set; }
    }
    internal class Question3
    {
        public static void Main(string[] args)
        {
            /*Create an Order class that has order id, item name, order date and quantity. Create a collection of Order objects.
             * Display the data day wise from most recently ordered to least recently ordered and by quantity from highest to lowest.*/
            List<Order> list = new List<Order>()
            {
                new Order(100,"Pen",new DateTime(2023,12,05),2),
                new Order(101,"Book",new DateTime(2023,12,01),5),
                new Order(102,"Pencil",new DateTime(2023,12,12),6),
                new Order(103,"phone",new DateTime(2023,12,10),1),
                new Order(104,"mouse",new DateTime(2023,12,02),3),
                new Order(105,"Paper",new DateTime(2023,11,28),10),
            };
            Console.WriteLine("data day wise from most recently ordered to least recently ordered");
            var result1=from d in list
                        orderby d.OrderDate descending
                        select d;
            foreach(var item in result1)
                Console.WriteLine($"Name : {item.OrderName} Date : {item.OrderDate.ToShortDateString()}");

            Console.WriteLine();
            Console.WriteLine("quantity from highest to lowest");
            var result2=from q in list
                        orderby q.OrderQnty descending
                        select q;
            foreach(var item in result2)
                Console.WriteLine($"Name : {item.OrderName} Quantity : {item.OrderQnty}");

        }
    }
}
