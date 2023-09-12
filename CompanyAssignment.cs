using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    /*WAP to create class company with method address. create class eBay which extends company implement address() 
     * differently in eBay class.Here the method address ()has been overridden in child class.*/
    internal class CompanyAssignment
    {
        static void Main(string[] args)
        {
            eBay e = new eBay();
            e.address();
            Company c = new Company();
            c.address();
        }
    }
    public  class Company
    {
        public virtual void address()
        {
            Console.WriteLine("Company class method");
        }
    }
    public class eBay: Company
    {
        public override void  address()
        {
            Console.WriteLine("eBay class method:");
        }
    }

}
