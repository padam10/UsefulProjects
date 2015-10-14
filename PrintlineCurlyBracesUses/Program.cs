using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintlineCurlyBracesUses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
                               {
                                   ID = 1,
                                   Name = "Padam",
                                   Department = "Physics"
                               };
           
            Console.WriteLine("Id: {0}, Department:{1}, Name: {2}", emp.ID,emp.Department,emp.Name);

            Console.Read();



        }
    }


     class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string  Department { get; set; }


    }
}
