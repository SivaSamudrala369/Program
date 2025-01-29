using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Project
{
    internal class Program
    {
        int Code, Quantity, value;

        public void AcceptData() 
        {
            Console.WriteLine("Enter the Item Code"); //+ "\n" + "1. Tea" + "\n" + "2. Coffee" + "\n" + "3. Puri" );
            this.Code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity");
            this.Quantity = Convert.ToInt32(Console.ReadLine());
                switch (Code) 
                {
                    case 1:
                    this.value = Quantity * 10;
                    break;
                    case 2:
                    this.value = Quantity * 20;
                    break;
                    case 3:
                    this.value = Quantity * 30;
                    break;
                    default:
                    Console.WriteLine("Invalid Code");
                    break;

                }
                Console.WriteLine("Final Price of the Order " + value);
                Console.ReadLine();
            
                
        }

        static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.AcceptData();

            Console.WriteLine(Obj);
            Console.ReadLine();
        }
    }
}
