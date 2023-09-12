using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal static class StaticAll
    {
        static void Main(string[] args)
        {
            Product.getdetails();
            Product.getdiscount();
            Product.Accept();
            Console.WriteLine();

        } 

    }
    public static class Product
    {
        static int id;
        static string name;
        static double price;

        static Product()
        {
            id = 101;
            name = "Pen";
            price = 120.00;
        }
        public static void Accept()
        {
            Console.WriteLine("Enter ID:");
            int i = Convert.ToInt32(Console.ReadLine());


        }
        public static void  getdetails()
        {
            Console.WriteLine("Product ID {0}: ",id);
            Console.WriteLine("Product Name {0}: " ,name);
            Console.WriteLine("Product Price {0}: ",price);
        }
        public static void  getdiscount()
        {
            double d_amt = price / 10;
            Console.WriteLine("Dicount amount is: {0}", d_amt);
            Console.WriteLine("total price is: {0}",price-d_amt);
        }
    }
    


}
