using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsPrograms.HomeWork
{
    /*1.Show difference between method overriding and method hiding by code*/
    internal class Oveeriding_abstract
    {
        static void Main(string[] args)
        {
            Employee00 e = new Employee00(12, "tanu", 12);
            e.Display();

        }
    }
    public abstract class person
    {
       
        protected int id;
        protected string name;
        

        public abstract void Display();
    }
    public class Employee00 
    {
        int emp_id;
        public Employee00(int id, string name, int emp_id) 
        {
            this.emp_id = emp_id;
        }
        public  void  Display()
        {
            Console.WriteLine($"ID: {emp_id}");
        }
    }
}