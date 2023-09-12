using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class Assign10Aug8
    {
 /*10) Write  Program for arithmetic  operation for each operation write separate Method using 
   parameter Passing and return type */
     static void Main(string[] args)
        {
            Arith a=new Arith();
            Console.WriteLine("Addition is : "+a.Add(10, 20));
            Console.WriteLine(a.Sub(100,90));
            Console.WriteLine(a.mul(10,2));
        }
    }
    public class Arith
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b) 
        {
           return a* b;
        }
        
    }

}
