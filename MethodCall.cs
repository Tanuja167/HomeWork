using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class MethodCall
    {
        /*8)Write  Program for arithmetic  operation for each operation write separate Method.*/
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add();
            c.Subtract();
            c.Multiplication();
            c.Divide();
                       
        }
    }
    public class Calculator
    {
        int num1 = 10;
        int num2 = 20;
        int result;
        public void Add()
        {
            result = num1 + num2;
            Display();
        }
        public void Subtract()
        {
            result = num1 - num2;
            Display();
        }
        public void Multiplication()
        {
            result = num1 * num2;
            Display();
        }
        public void Divide()
        {
            result = num1 / num2;
            Display();
        }
        public void Display()
        {
            Console.WriteLine(result);
            
        }
    }
}
