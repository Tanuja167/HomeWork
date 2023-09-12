using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class Static
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1,"tanu");
            Student s2 = new Student(1, "tanu");
            Student s3 = new Student(1, "tanu");
            Console.WriteLine(s1.Display());
            Console.WriteLine( Student.reduce());
            Console.WriteLine(s2.Display());
            Console.WriteLine(Student.reduce());
            Console.WriteLine(s3.Display());
            Console.WriteLine("total seat remaining: "+Student.reduce());
        }
    }
    public class Student
    {
        private int id;
        private string name;
        private static int total = 20;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
           
        }
        public static int reduce()
        {
            total--;
            return total; 
        }
        public string Display()
        {
            return $"Student ID:{id}, Name: {name}";
        }
    }
}
