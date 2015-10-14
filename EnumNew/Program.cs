using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNew
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Due { get; set; }



        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

       

    }



    public enum EmployeeType
    {
        FullTime,
        PartTime,
        PerDiem
    }

    
}
