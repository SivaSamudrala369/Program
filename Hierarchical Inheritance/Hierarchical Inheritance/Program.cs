using System;

namespace HierarchicalInheritance
{
    public class ARMY
    {
        public void Siva()
        {
            Console.WriteLine("Failure");
        }
        public class POLICE : ARMY
        {
            public void Naresh()
            {
                Console.WriteLine("Success");
            }
        }
        public class IPS : ARMY
        {
            public void Ravi()
            {
                Console.WriteLine("Well Position");
            }
        }
        public class DGP : ARMY
        {
            public void Teja() 
            {
                Console.WriteLine("Retired");
            }
            static void Main(string[] args)
            {
                POLICE obj1 = new POLICE();
                IPS obj2 = new IPS();
                DGP obj3 = new DGP();
                obj1.Siva();
                obj1.Naresh();
                obj2.Ravi();
                obj3.Teja();

            }
        }
    }
}
//output:Failure,Success,Well Position,Retired
