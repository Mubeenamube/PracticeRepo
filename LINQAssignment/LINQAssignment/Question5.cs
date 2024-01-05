using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class Item
    {
        public Item(string itemName, long itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        public string ItemName { get; set; }
        public long ItemPrice { get; set; }
    }
    class OrderItem
    {
        public OrderItem(int orderID, string itemName, DateTime orderDate, double totLPrice)
        {
            OrderID = orderID;
            ItemName = itemName;
            OrderDate = orderDate;
            TotLPrice = totLPrice;
        }

        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotLPrice { get; set; }
    }
    internal class Question5
    {
        static void Main(string[] args)
        {
            /*You have created Order class in the previous exercise and that has order id , item name, order date and quantity . 
             Create another class called Item that has item name and  price. Write a LINQ query such that it returns order id, item name, 
             order date and the total price (price * quantity ) grouped by the month in the descending order of the order date.*/

            List<Order> list1 = new List<Order>()
            {
                new Order(100,"Pen",new DateTime(2023,09,05),2),
                new Order(101,"Book",new DateTime(2023,10,01),5),
                new Order(102,"Pencil",new DateTime(2023,08,12),6),
                new Order(103,"phone",new DateTime(2023,12,10),1),
                new Order(104,"mouse",new DateTime(2023,10,02),3),
                new Order(105,"Paper",new DateTime(2023,11,28),10),
            };
            List<Item> list2 = new List<Item>()
            {
                new Item("Pen",10),
                new Item("Book",60),
                new Item("Pencil",5),
                new Item("phone",100000),
                new Item("mouse",1000),
                new Item("Paper",2),
            };

            var result = from order in list1
                         join item in list2
                         on order.OrderName equals item.ItemName
                         select new OrderItem(order.OrderID, item.ItemName, order.OrderDate, order.OrderQnty * item.ItemPrice);
            var result1=from or in result
                        orderby or.OrderDate descending
                        group or by or.OrderDate.Month;

            foreach(var item in result1)
            {
                foreach(var  item2 in item)
                    Console.WriteLine($"OrderId : {item2.OrderID} ItemName : {item2.ItemName} OrderDate : {item2.OrderDate.ToShortDateString()} TotalPrice : {item2.TotLPrice}");
            }

        }
    }
}
