using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class StaticUse
    {
        static void Main(string[] args)
        {
            student s = new student(101, "Tanu", 22);
            student s1 = new student(102, "Alisha", 23);
            Console.WriteLine(student.GetId());
            s.display();
            s1.display();
        }
    }
    public class student
    {
        public int id;
        public string name;
        public int age;
        static int count;
        public  student(int id, string name, int age)
        {
            count++;
            this.id = count;
            this.name = name;
            this.age = age;
        }
        public static int  GetId()
        {
            return count;
        }
        public void display()
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Age: {age}");
        }
    }
}
