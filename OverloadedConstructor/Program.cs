using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Datascan ds = new Datascan();

            //Datascan ds1 = new Datascan(100); //This does not compile because the derived class Datascan only have one constructor
            // which does not take any arguments that is why it does not compile. 
            // In C#, constructors are not inherited by the base class. 

            IBM ibm = new IBM(300); // This will compile because it explicitly  telling the compiler to which one to call. 

            Console.Read();
        }
    }

    class Software   // called base class in C#
    {
        
        public Software()
        {
            num1 = 100;
        }

        public Software(int num2)
        {
            num1 = num2;
        }

        protected int num1;
    }

    class Datascan : Software
    {
        public Datascan()
        {
            Console.WriteLine(num1);
        }
    }

    class IBM : Software
    {
        public IBM(int id):base(id)
        {
            Console.WriteLine(num1);
        }
    }
}
