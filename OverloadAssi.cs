using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    /*1) WAP to create a class Kid with method readBook() and another method readBook () with 2 parameters. The method
       readBook here is over-loaded (same method name but different parameters) Create a class BigKid which extends
       Kid created above. Implement readBook() differently in BigKid class. Here the method readBook() has been 
      over-ridden in the child class BigKid()*/

    internal class OverloadAssi
    {
        static void Main(string[] args)
        {
            BigKid b=new BigKid();
            b.readBook();
            b.readBook("ABC", 70);
        }
    }
    public class Kid
    {
        string book_name;
        int price;
        
       public virtual void readBook()
        {
            Console.WriteLine("ReadBook");
        }
        public  void readBook(string book_name, int price)
        {
            this.book_name = book_name;
            this.price = price;
            Console.WriteLine("Book Name"+book_name+" Price:"+price);
        }
    }
    public class BigKid: Kid
    {
        public override void readBook()
        {
            Console.WriteLine("ReadBook");
        }

    }
}
