using System;

namespace InheritanceDemo
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Hello from Animal Greet Method");}

        public void Talk()
        {
            Console.WriteLine("Talk method from Animal Class");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Sing method from Animal class");
        }
    }

    class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Constructor from Dog class");
        }

        public new void Talk()
        {
            Console.WriteLine("Talk method from Dog class");
        }

        public override void Sing()
        {
            Console.WriteLine("Sing method from Dog class");
        }
    }
}

