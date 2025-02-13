using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll // Delegates represents the Function/Method
{
    //Creatinf Delegates
    delegate void MulticastDelegate(int a, int b);
    //AccessModifier delegate ReturnType DelegateName([parameters]) 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Siva");
            Deposite.Class1 S1 = new Deposite.Class1();
            MulticastDelegate SD = new MulticastDelegate(S1.Add); // Creating Objecct
            // DelegateName DelegateObjectName = new DelegateName(Function)
            // Calling Methods in Single Cast Delegate
            // Calling Methods in Multi Cast Delegate
            SD += S1.Sub; //DelegateObjectName(parameters)--> For Single Cast Delegate 
            SD += S1.Mul; // DelegateObjectName += Object.MethodName--> For Multi Cast Delegate
            SD += S1.Div;
            SD(30, 40);
            Console.WriteLine("--------------------------------------");
            SD -= S1.Sub;
            SD -= S1.Div;
            SD -= S1.Add;
            SD(60, 20);
            Console.ReadKey();

        }
    }
    
}
