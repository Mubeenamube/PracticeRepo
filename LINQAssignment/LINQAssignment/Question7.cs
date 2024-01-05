using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQAssignment
{
    internal class Question7
    {
        public static void Main(string[] args)
        {
            /*Check if all the quantities in the Order collection is >0
            Get the name of the item that was ordered in largest quantity in a single order. (Hint: use LINQ methods to sort)
            Find if there are any orders placed before Jan of this year.*/
            List<Order> list1 = new List<Order>()
            {
                new Order(100,"Pen",new DateTime(2023,09,05),2),
                new Order(101,"Book",new DateTime(2023,10,01),5),
                new Order(102,"Pencil",new DateTime(2023,08,12),6),
                new Order(103,"phone",new DateTime(2023,12,10),1),
                new Order(104,"mouse",new DateTime(2023,10,02),3),
                new Order(105,"Paper",new DateTime(2023,11,28),10),
            };
            
        }
    }
}
