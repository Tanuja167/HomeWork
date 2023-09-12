using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopsPrograms.HomeWork
{
    internal class removeduplicatelist
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            /*list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(2);*/

            for(int i=0;i<=5;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }

           /* for(int i=0;i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }*/
            /*list.ForEach(it => Console.WriteLine(it));*/

            Console.WriteLine("After remove");

           

            for (int i=0;i< list.Count; i++)
            {
                for(int j=i+1;j<list.Count;j++)
                {
                    if (list[i] == list[j])
                    {
                        list.Remove(list[j]);
                        j--;

                    }                   
                }
            }
            Console.WriteLine();
            Console.WriteLine("Uniqueq ele: ");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
