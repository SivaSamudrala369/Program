
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SBI Bank");
            // namespace.ClassName object = new namespace.ClassName();
            //object.MethodName();
            Deposite.Class1 obj = new Deposite.Class1();
            obj.Ravi();

            Withdraw.Class1 obj1 = new Withdraw.Class1();
            obj1.Siva();

            CheckBalance.Class1 obj2 = new CheckBalance.Class1();
            obj2.Naresh();

        }
    }
}
