using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_single
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("BArking");
        }
        static void Main(string[] args)
        {
            Dog siva = new Dog();
            siva.Bark();
            siva.Eat();

        }

    }
}