using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionHandling
{
    using System.IO;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader streamReader = new StreamReader(@"C:\Documents\UsefulProjects\ExceptionHandling\Data.txt");

            try
            {
                //StreamReader streamReader = new StreamReader(@"C:\Folder\Data.txt");
                StreamReader streamReader = new StreamReader(@"C:\Documents\UsefulProjects\ExceptionHandling\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (Exception ex)
            {

               Console.WriteLine("could not find the file ");
               Console.WriteLine(ex.StackTrace);
            }



            Console.Read();
        }
    }
}
