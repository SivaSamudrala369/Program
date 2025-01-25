using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance_in_Class
{
    class Rectangle
    {
        int Length, Breadth, Perimeter;
        protected int Area;
        public virtual void AcceptData()

        {
            Console.WriteLine("Enter the Length of a Rectangle = ");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of a Rectangle = ");
            Breadth = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Calculate()
        {
            Area = Length * Breadth;
            Perimeter = 2 * (Length + Breadth);
        }
        public override string ToString()
        {
            string Output = "The Area of the Rectangle = " + Area + "\nThe Perimeter of the Rectangle = " +
            Perimeter;
            return Output;
        }
    }
    class Cuboid : Rectangle
    {
        int Height, volume;
        public override void AcceptData()
        {
            base.AcceptData();
            Console.WriteLine("Enter the Height of the Cuboid = ");
            Height = Convert.ToInt32(Console.ReadLine());
        }
        public override void Calculate()
        {
            base.Calculate();
            volume = base.Area * Height;
        }
        public override string ToString()
        {
            string Output = "The volume of the Cuboid is = " + volume;
            return Output;
        }
    }
    class Example_04
    {
        static void Main()
        {
            Cuboid C1 = new Cuboid();
            C1.AcceptData();
            C1.Calculate();
            Console.WriteLine(C1);
            Console.ReadKey();
        }
    } 
}
//OutPut:
        //Enter the Length of a Rectangle =8
        //Enter the Breadth of a Rectangle =6
        //Enter the Height of the Cuboid =5
        //The volume of the Cuboid is = 240
