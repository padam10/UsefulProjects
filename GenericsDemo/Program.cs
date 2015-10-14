using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Allow us to create an class decoupled from the datatypes
// extensively used by the collections. 

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = Calculator.AreEqual<int>(10, 10);
            bool areEqual2 = Calculator.AreEqual<string>("Padam", "padam");

            if (areEqual)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine(" They are : " + areEqual2);

            Console.Read();
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T num1, T num2)
        {
            return num1.Equals(num2);
        }
    }
}
