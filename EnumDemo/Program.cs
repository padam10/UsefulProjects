using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
            Customer [] customers = new Customer[3];
            customers[0] = new Customer() {Name = "Padam", Gender= Gender.Male};
            customers[1] = new Customer() {Name = "Jane", Gender = Gender.Female};
            customers[2] = new Customer() {Name = "Yate", Gender = Gender.Unknown};

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Gender);
            }

            Console.Read();
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }


    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

}
