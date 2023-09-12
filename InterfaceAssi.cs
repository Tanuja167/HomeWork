using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class InterfaceAssi
    {
        static void Main(string[] args)
        {
             Derive d=new Derive();
            Console.WriteLine(d.Add(5,6));
            Console.WriteLine(d.sub(20,10));
        }
    }

    public interface Iprintable
    {
        int Add(int a, int b);

    }
    public interface Ishow
    {
        int sub(int x, int y);
    }
    public class Derive: Iprintable, Ishow
    {
       public int Add(int i, int j)
        {
            return i + j;
        }
        public int sub(int m, int n)
        {
            return m - n;
        }

    }
}
