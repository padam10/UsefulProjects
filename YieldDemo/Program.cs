using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// with the yeild you do not need to create an list 
// 

namespace YieldDemo
{
    class Program
    {
        static Random rand = new Random();

        private static IEnumerable<int> GetRandomNumbers(int count)
        {

            for (int i = 0; i < count; i++)
            {
                yield return rand.Next();
            }
        }

        static void Main(string[] args)
        {
            foreach (int num in GetRandomNumbers(10))
            {
                Console.WriteLine(num);
            }

            Console.Read();
        }
    }
}
