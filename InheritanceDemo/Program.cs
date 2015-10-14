using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
In C# you need to explicitly use the virtual and override keyword exclusively implement inheritance. 


 */

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal anm = new Dog();
            anm.Talk();// this will execute the method from parent class(Animal) because it is not declared as virtual

            anm.Sing();// This will execute the method from derived class, because it is declared as virtual in the base class
                       // And it is declared as overide in the derived class. 

            Console.Read();

        }
    }
}
