using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class Cube
    {
        /*12) write a program to calculate cube for given number using no return type ,with 
         * return type, with parameter passing, with parameter and return type. */

        static void Main(string[] args)
        {
            Cube11 c = new Cube11();
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            c.CalCube(num);
            c.display();
            Console.WriteLine(c.CalCube1(3)); 

        }
    }
    public class Cube11
    {
        public int result = 0;
        public void CalCube(int n)
        {
            
            if(n>0)
            {
                result = n * n * n;
                
            }
            else
            {
                Console.WriteLine("enter valid number: ");
            }
        }
        public void display()
        {
            Console.WriteLine(result);
        }

        public int CalCube1(int n)
        {

            if (n > 0)
            {
                result = n * n * n;
                return result;

            }
            else
            {
                return 0;
            }
        }

    }
}
