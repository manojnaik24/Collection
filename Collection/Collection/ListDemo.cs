using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ListDemo
    {
        public void Lists()
        {
            List<int> list=new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            List<string> listring  = new List<string>();
            listring.Add("Manoj");
            listring.Add("Kuamr");
            listring.Add("jaswanth");
            foreach (string s in listring) 
            {
                Console.WriteLine(s);
            }

            List<double> lisdouble = new List<double>();
            lisdouble.Add(11.1);
            lisdouble.Add(2.32);
            lisdouble.Add(3.35);
            foreach (double m in lisdouble)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
            lisdouble.Remove(2.32);
            foreach (double item in lisdouble)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine();
            lisdouble.Remove(1);
            foreach (double item in lisdouble)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine("REVERES");
            //   list.Reverse();
            //  list.RemoveRange(1,3);

            Console.WriteLine("Count:"list.Count);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
