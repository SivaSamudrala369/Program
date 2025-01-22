using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {

        public void NoReturn()
        {
            Console.WriteLine("If we use void No retun type");
        }
        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int sub(int a, int b)
        {
            int result = a - b;
            return result;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.NoReturn();
            int subres = obj.sub(4, 2);
            Console.WriteLine(subres);

            // Using Static, method syntax 
            int res = Program.Add(6, 7);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}