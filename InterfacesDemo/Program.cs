using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
   public interface ICustomer
   {
        //int Id is not allowed it can not have any fields
       void Print();

       int Add(int a, int b);

   }

    public interface IStudent
    {
        string GetName(string name);
    }

    public class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Hello Customer");
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public string GetName(string name)
        {
            return name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();

            Console.WriteLine(c1.Add(2,3));

            ICustomer cust = new Customer();
            Console.WriteLine(cust.Add(4,5));

            Console.WriteLine(c1.GetName("Padam"));

            Console.Read();
        }
    }

}
