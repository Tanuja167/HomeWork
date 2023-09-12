using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class FindMax
    {
        static void Main(string[] args)
        {
            Max m = new Max();
            Console.WriteLine("enter two numbers:");
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());
           string a= m.CheckNumber(n1, n2);
            Console.WriteLine(a);
        }
    }
    public class Max
    {
        public string CheckNumber(int a, int b)
        {
            string msg = "";
            if(a>b)
            {
                msg = $"{a}: Number one is greater";
            }
            else
            {
                msg = $"{b} : Number two is greater";
            }
            return msg;
        }
    }
}
