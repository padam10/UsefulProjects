using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This refers to the class members. If you type this. you will see the list of properties
//associated with the particular class. 
// This keyword is used to avoid the ambiguity. This means the object of the 
// the current class. 
// for eg if you do this.Id = Id, this.Id belongs to the class and Id is 
// comming from the parameter. 

// This keyword is also used to intialize the vairbale in previous constructor and call it there. 

namespace ThisKeyword
{
    class Program
    {
        public class Customer
        {
            private int AcNo;

            private string Name;

            private double Bal;

            private string ConNo;

            public Customer() 
            {
                Console.WriteLine("Hello World");
            }

            public Customer(int acNo, string name, double bal)
            {
                this.AcNo = acNo;
                this.Name = name;
                this.Bal = bal;
            }

            public Customer(int acNo, string name, double bal, string conNo):this(acNo,name,bal)
            {
                //this.AcNo = acNo;
                //this.Name = name;
                //this.Bal = bal;
                this.ConNo = conNo;
            }

            public void Deposit(double amt)
            {
                Bal = Bal + amt;
            }

            public void Withdraw(double amt)
            {
                Bal = Bal - amt;
            }

            public void BalEnq()
            {
                Console.WriteLine("ActNo:{0},Balance:{1}",AcNo,Bal);
            }
           }

        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            Customer c2 = new Customer(123, "Padam ", 500.23);
            c2.BalEnq();

            Customer c3 = new Customer(542,"Padam",12.0, "714-205-3564");
            c3.BalEnq();
            Console.Read();

        }
    }
}
