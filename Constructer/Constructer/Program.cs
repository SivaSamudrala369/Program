using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Constructors_Multiple
{ 
    class Employee_03
    {
        int EmpId;
        string EName, Designation;
        double Salary;
        public Employee_03(int Id, string S1, string S2, double Sal)
        {
            this.EmpId = Id;
            this.EName = S1;
            this.Designation = S2;
            this.Salary = Sal;
        }
        public Employee_03()
        {
            this.EmpId = 103;
            this.EName = "Jigisha";
            this.Designation = "DSE";
            this.Salary = 55000;
        }
        public Employee_03(int Id, string S1, String S2, int Sal)
        {
            this.EmpId = Id;
            this.EName = S1;
            this.Designation = S2;
            this.Salary = Sal;
        }
        public override string ToString()
        {
            string Output = "Employee Id is = " + this.EmpId + "\n" + "Employee name = " + this.EName + "\n" +
            "Employee Designation = " + this.Designation + "\n" + "Employee Salary = " + this.Salary;
            return Output;
        }
    }

    class Example_03
    {
        static void Main()
        {
            Employee_03 E1 = new Employee_03(101, "Raju", "Developer", 45000);
            Employee_03 E2 = new Employee_03(102, "Gopal", "TL", 65000);
            Employee_03 E3 = new Employee_03();
            Employee_03 E4 = new Employee_03(104, "Anand", "Developer", 50000);
            Console.WriteLine(E1);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(E2);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(E3);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(E4);
            Console.ReadLine();
        }
    }
}
