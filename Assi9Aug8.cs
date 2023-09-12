using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{

    /*9) Write Program for arithmetic  operation for each operation write separate Method using
     * parameter Passing */
     
    internal class Assi9Aug8
    {
        static void Main(string[] args)
        {
            Operation o = new Operation();
            o.Add(10, 20, 30);
            o.Display();
            o.Sub(100,90);
            o.Display();
            o.Mul(10, 2);
            o.Display();

        }
    }
    public class Operation
    {
        private int result;
        public void Add(int a, int b, int c)
        {
            result = a + b + c;
        }
        public void Sub(int a, int b)
        {
            result = a-b;
        }
        public void Mul(int a, int b)
        {
            result = a*b;
        }
        public void Display()
        {
            Console.WriteLine("result is: "+result);
        }
    }
}
