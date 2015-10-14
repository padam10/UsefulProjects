using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class used the library demo. 

namespace ClassLibraryDemo2
{
    using ClassLibraryDemo;

    class Program
    {
        static void Main(string[] args)
        {
            Algebra algebra = new Algebra();
            double num1 = 10;
            double num2 = 10;
            double addTotal = algebra.Addition(num1, num2);
            double subTotal = algebra.Sub(num1, num2);
            double multTotal = algebra.Multplication(num1, num2);

            Console.WriteLine("Addition: {0}, Substraction: {1}, Multiplication: {2}",addTotal,subTotal,multTotal);
            Console.Read();


        }
    }
}
