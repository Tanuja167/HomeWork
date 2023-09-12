using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class Assi11Aug8
    {
        /*11) write a program to calculate square for given number using no return type ,with 
         * return type, with parameter passing, with parameter and return type.*/

        static void Main(string[] args)
        {
            Square s=new Square();
            Console.WriteLine(s.Cal(3));
            s.Calsq(5);
            s.Display();
            Console.WriteLine(s.CAL(2));




        }

    }
    public class Square
    {
        private int sq = 0;
        public int Cal(int x)
        {
            sq = x * x;
            return sq;
        }
        public void Calsq(int x)
        {
            sq = x * x;
            
        }
        public void Display()
        {
            Console.WriteLine(sq);
        }
        public int CAL(int n)
        {
            sq = n * n;
            return sq;
        }

    }
}
