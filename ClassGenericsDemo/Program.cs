using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = Calculator<int>.AreEqual(10, 10);
            bool areEqual2 = Calculator<string>.AreEqual("Padam", "padam");

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

    public class Calculator<T>
    {
        public static bool AreEqual(T num1, T num2)
        {
            return num1.Equals(num2);
        }
    }
}