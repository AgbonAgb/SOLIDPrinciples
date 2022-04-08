// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace SOLIDPrinciples
{
    class Program
    {
        //private readonly IOpenClose2 _openClose2;
        static void Main(string[] args)
        { 

            IOpenClose2 iopc = new GoldCustomers();            
            double goldCustomerDisAmount = iopc.GetSalesDiscount(10000);
            Console.WriteLine($"Gold Customer's Discount: {goldCustomerDisAmount}");

            iopc = new SilverCustomers();    
            double silverCustomerDisAmount = iopc.GetSalesDiscount(10000);
            Console.WriteLine($"Silver Customer's Discount: {silverCustomerDisAmount}");

            iopc = new PlatinumCustomers();
            double platinumCustomerDisAmount = iopc.GetSalesDiscount(10000);
            Console.WriteLine($"Platinum Customer's Discount: {platinumCustomerDisAmount}");

            Console.ReadKey();
           


            Console.ReadKey();
        }
    }
}
