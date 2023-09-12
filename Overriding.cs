using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static OopsPrograms.HomeWork.employee;

namespace OopsPrograms.HomeWork
{
    internal class Overriding
    {
        /*From the existing Employee class create new child class called SalesEmployee& 
            implement the inheritance(bonus+comm) & polymorphism(method overriding)*/
        static void Main(string[] args)
        {
            employee s = new SalesEmployee(101, "Tanuja", 56000.00, 1000, 20000);
            
            s.cal();
            s.Display();
            employee e = new employee(12, "alisha", 56000);
            e.cal();
            e.Display();
            
        }
    }
    public class employee
    {
        protected int id;
        protected string name, gender;
        protected double salary;
        public employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public virtual void cal()
        {
            Console.WriteLine(salary); 
        }
        public virtual void Display()
        {
            Console.WriteLine("EMployee Name: " + name + " ID: " + id + " Salary: " + salary);
        }
    }
        public class SalesEmployee : employee
        {
            private int comm, bouns;
            public SalesEmployee(int id, string name, double salary, int comm, int bouns) 
                :base(id, name, salary)
            {
                this.comm = comm;
                this.bouns = bouns;
            }
            public override void cal()
            {
                salary=comm+bouns;
            }
            public override void Display()
            {
                Console.WriteLine("EMployee Name: " + name + " ID: " + id + " Salary: " + salary);
            }
        }
    
}

        

