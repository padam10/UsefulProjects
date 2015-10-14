using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Employee
    {
        public int Id { get; set; }

        public string  FName { get; set; }

        public void Display(int id, string fname)
        {
            Console.WriteLine("Id is " + id + " and First Name is : " + fname);
        }
    }
}
