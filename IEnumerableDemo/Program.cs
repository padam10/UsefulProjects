using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The following example implements Ienumerable, it is 
            When you need to go through the list Ienumerable is good  and it is immutable so saves memrory. 

             */
            List<string> mylist = new List<string>();
            mylist.Add("shane");
            mylist.Add("Amber");
            mylist.Add("sTJ");
            mylist.Add("sJohn");

            IEnumerable<string> names = from n in mylist where (n.StartsWith("s")) select  n;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }

        
    }
}
