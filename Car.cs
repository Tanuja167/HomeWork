using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    /*1.	Create a class Car with String model and int totalCarSold as static variable in
             main() method.  */
    internal class Car
    {
        static void Main(string[] args)
        {
           Car11 c=new Car11();
            c.Accept("creta");
            string result = c.display();
            Console.WriteLine(result);
            Car11 c1 = new Car11();
            c1.Accept("brezaa");
            Console.WriteLine(c1.display());
            
            Console.WriteLine("Total number of car sold: "+Car11.Count());
        }
    }
    public class Car11
    {
        private string model;
        private int no;
        public static int totalCarSold = 0;

       
        public static int Count()
        {
            return totalCarSold;
        }
        public void Accept(string model)
        {
            totalCarSold++;
            this.model = model;
            this.no = totalCarSold;
        }
        public string display()
        {
            return $"Model: {model}, TotalCarSold: {no}";
        }


    }
}
