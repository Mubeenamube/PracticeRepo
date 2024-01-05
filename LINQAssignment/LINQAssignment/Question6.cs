using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{   
    internal class Question6
    {
        public static void Main(string[] args)
        {
            //Do the previous exercise using anonymous types.
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
                         select new {op=order.OrderID,op1=item.ItemName,op2=order.OrderDate,op3=order.OrderQnty * item.ItemPrice };
            var result1 = from or in result
                          orderby or.op2 descending
                          group or by or.op2.Month;

            foreach (var item in result1)
            {
                foreach (var item2 in item)
                    Console.WriteLine($"OrderId : {item2.op} ItemName : {item2.op1} OrderDate : {item2.op2.ToShortDateString()} TotalPrice : {item2.op3}");
            }
        }
    }
}
