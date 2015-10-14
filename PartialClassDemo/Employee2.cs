using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Employee
    {
        public string LastName { get; set; }

        public string  Major { get; set; }

        public void DisplayLastNameAndMajor()
        {
            Console.WriteLine("LastName: {0}, and , Major: {1}", this.LastName,this.Major);
        }
    }
}
