using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Partial class splits the definition of a class over two or more sources files. You can create the 
defination in two different files but compile as one. 

Points to remember 
1. You must have partial key word in each part of the partial class
2. All the partial classes should be in the same namespace
3. Each part the partial class have the same accessibility
4. If a part of the partial class is abstract, entire class becomes abstract

 */

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
                               {
                                   Id = 1,
                                   Major = "CS",
                                   LastName = "Manning",
                                   FName = "Payton"
                               };
            emp.Display(500, "CNN");
            emp.DisplayLastNameAndMajor();
            Console.Read();

        }
    }
}
