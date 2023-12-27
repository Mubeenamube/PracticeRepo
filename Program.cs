using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConsoleApp
{
    internal class Program
    {
        class Furniture
        {
            public int OrderId;
            public string OrderDate;
            public string FurnitureType;
            public int Qnty;
            public double TotalAmt;
            public string PaymentMode;

            public void GetData()
            {
                Console.WriteLine("Enter Order Details:");
                Console.Write("Order ID: ");
                OrderId = int.Parse(Console.ReadLine());
                Console.Write("Order Date: ");
                OrderDate = Console.ReadLine();
                Console.Write("Furniture Type (Chair/Cot): ");
                FurnitureType = Console.ReadLine();
                Console.Write("Quantity: ");
                Qnty = int.Parse(Console.ReadLine());
                Console.Write("Total Amount: ");
                TotalAmt = double.Parse(Console.ReadLine());
                Console.Write("Payment Mode (Credit/Debit): ");
                PaymentMode = Console.ReadLine();
            }

            public void ShowData()
            {
                Console.WriteLine($"Order ID: {OrderId}");
                Console.WriteLine($"Order Date: {OrderDate}");
                Console.WriteLine($"Furniture Type: {FurnitureType}");
                Console.WriteLine($"Quantity: {Qnty}");
                Console.WriteLine($"Total Amount: {TotalAmt}");
                Console.WriteLine($"Payment Mode: {PaymentMode}");
            }
        }
        class Chair:Furniture
        {
            public string ChairType;
            public string Purpose;
            public string WoodType;
            public string SteelType;
            public string PlasticColor;
            public decimal Rate;

            public void GetData()
            {
                base.GetData();
                Console.WriteLine("Enter Chair Details:");
                Console.Write("Chair Type (Wood/Steel/Plastic): ");
                ChairType = Console.ReadLine();
                Console.Write("Purpose (Home/Office): ");
                Purpose = Console.ReadLine();

                if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Wood Type (Teak Wood/Rose Wood): ");
                    WoodType = Console.ReadLine();
                }
                else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Steel Type (Gray Steel/Green Steel/Brown Steel): ");
                    SteelType = Console.ReadLine();
                }
                else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Plastic Color (Green/Red/Blue/White): ");
                    PlasticColor = Console.ReadLine();
                }

                Console.Write("Rate: ");
                Rate = Convert.ToDecimal(Console.ReadLine());
            }

            public void ShowData()
            {
                base.ShowData();
                Console.WriteLine($"Chair Type: {ChairType}");
                Console.WriteLine($"Purpose: {Purpose}");

                if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Wood Type: {WoodType}");
                }
                else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Steel Type: {SteelType}");
                }
                else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Plastic Color: {PlasticColor}");
                }

                Console.WriteLine($"Rate: {Rate}");
            }
        }
        class Cot:Furniture
        {
            public string CotType;
            public string WoodType;
            public string SteelType;
            public string Capacity;
            public decimal Rate;

            public void GetData()
            {
                base.GetData();
                Console.WriteLine("Enter Cot Details:");
                Console.Write("Cot Type (Wood/Steel): ");
                CotType = Console.ReadLine();

                if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Wood Type (Teak Wood/Rose Wood): ");
                    WoodType = Console.ReadLine();
                }
                else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Steel Type (Gray Steel/Green Steel/Brown Steel): ");
                    SteelType = Console.ReadLine();
                }
                Console.Write("Capacity (Single/Double): ");
                Capacity = Console.ReadLine();
                Console.Write("Rate: ");
                Rate = Convert.ToDecimal(Console.ReadLine());
            }
            public void ShowData()
            {
                base.ShowData();
                Console.WriteLine($"Cot Type: {CotType}");

                if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Wood Type: {WoodType}");
                }
                else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Steel Type: {SteelType}");
                }

                Console.WriteLine($"Capacity: {Capacity}");
                Console.WriteLine($"Rate: {Rate}");
            }
        }
        static void Main(string[] args)
        {
            Chair chair = new Chair();
            chair.GetData();
            chair.ShowData();

            Console.WriteLine("\n--------------------------------\n");

            Cot cot = new Cot();
            cot.GetData();
            cot.ShowData();
        }
    }
}
