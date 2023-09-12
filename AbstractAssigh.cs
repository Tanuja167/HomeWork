using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class AbstractAssigh
    {
        static void Main(string[] args)
        {
            ibook p = new ibook();
            p.accept(1234567891, "Sandesh");
            p.Display();
        }
    }
    /*You have to build a phone book.
  The phone book has the name and contact of a person. 
  This is an openly accessible book so it should be designed accordingly*/

    public abstract class Abstarct_Phonebook
    {
        public long phone_number;
        public string contact_name;

        public abstract void accept(long phone_number, string contact_name);

        public abstract void Display();
    }


    public class ibook : Abstarct_Phonebook
    {
        public override void accept(long phone_number, string contact_name)
        {
            this.phone_number = phone_number;
            this.contact_name = contact_name;
        }
        public override void Display()
        {
            Console.WriteLine($"Number :{phone_number}\nName :{contact_name}");
        }
    }
}
