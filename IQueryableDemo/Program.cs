using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ints = new[] { 1, 9, 3, 4, 7, 8, 9, 10 };

            IEnumerable<int> result = ints.Where((i => i < 5));

            foreach (int i in  result)
            {
                Console.WriteLine(i);
            }

            

            Console.Read();

        }
    }

    
}
