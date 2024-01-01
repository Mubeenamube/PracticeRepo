using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandsOnDay6
{
    internal class Question6
    {

        class BookStore
        {
            public int Id { get; set; }
            public string Name { get; set; }
            
            public void display()
            {
                Hashtable list = new Hashtable();
                list.Add(1200, "kjhb");
                list.Add(1201, "jfcvbh");
                list.Add(1202, "kjhb");
                list.Add(1203, "jfcjhbh");

                foreach (var ob in list.Keys)
                {
                    Console.WriteLine($"ID : {ob} Name : {list[ob]}");
                }
            }
        
        }
        static void Main(string[] args)
        {
            /*6. Create a class called BookStore with fields Bookid and Bookname.
              Accept and display the  details using HashTable.*/
            BookStore bookStore = new BookStore();
            bookStore.display();
        }
    }
}
