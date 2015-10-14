using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UsefulProjects
{
    class Program
    {
        private static void Main(string[] args)
        {

            List<Employee> emplist = new List<Employee>()
                                         {
                                             new Employee() { Id = 1, Name = "Padam" },
                                             new Employee() { Id = 2, Name = "Datascan" }
                                         };

            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp.Id + " " + emp.Name);
            }

            Console.WriteLine("This is the different List ");

            List<Employee> emplist2 = new List<Employee>();
            emplist2.Add(new Employee() { Id = 10, Name = "Jane" });
            emplist2.Add(new Employee() { Id = 11, Name = "Joe" });

            foreach (Employee emp in emplist2)
            {
                Console.WriteLine(emp.Id + " " + emp.Name);
            }

            Console.Read();

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
    }
}
