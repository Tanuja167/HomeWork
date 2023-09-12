using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class NewCar
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.Accept("i10");
            Console.WriteLine(c.Print());
            car c1 = new car();
            c.Accept("Hundai");
            Console.WriteLine(c1.Print());
            // Console.WriteLine(car.totalcarsold);
            car.totalcarsold = 100;
            Console.WriteLine(  );
            Console.WriteLine( c1.Print());

        }
    }
    public class car
    {
        private string modelname;
         public static int totalcarsold=0;

        public void Accept(string modelname)
        {
            totalcarsold++; 
            this.modelname = modelname;
        }
        public string Print()
        {
            return $"Model: {modelname}, Total car sold: {totalcarsold}";
        }

    }
}
