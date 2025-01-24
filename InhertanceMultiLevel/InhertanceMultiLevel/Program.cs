using System;

namespace InhertanceMultiLevel
{
    public class Kurnool
    {
        public void Siva()
        {
            Console.WriteLine("Developer");
        }
        static void Main(string[] args)
        {
            Aspari mass = new Aspari();
            mass.Ravi();
            mass.Siva();
            mass.Naresh();
        }
    }
    public class Kakinada : Kurnool
    {
        public void Ravi()
        {
            Console.WriteLine("Wipro Developer");
        }
    }
    public class Aspari : Kakinada
    {
        public void Naresh()
        {
            Console.WriteLine("SoftWare Engineer");
        }
    }
    
}
// Object creats only child class
//We can place Main Method in Any Class