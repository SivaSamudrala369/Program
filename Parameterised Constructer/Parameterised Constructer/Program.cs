using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Constructors_programs_by_Mahesh_Sir
{
    class Employee_03
    {
        int EmpId;
        string EName, Designation;
        double Salary;
        public Employee_03(int Id, string S1, string S2, double Sal)
        {
            EmpId = Id;
            EName = S1;
            Designation = S2;
            Salary = Sal;
        }
        public override string ToString()
        {
            string Output = "Employee Id is = " + EmpId +  "\n" +
            "Employee Designation = " +Designation + "\n" +  "Employee name = " + EName + "\n" + "Employee Salary = " + Salary;
            return Output;
        }
    }
    class Example_03

    {
        static void Main()
        {
            Employee_03 E1 = new Employee_03(101, "Raju", "Developer", 45000);
            Employee_03 E2 = new Employee_03(102, "Gopal", "TL", 65000);
            Console.WriteLine(E1);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(E2);
            Console.ReadLine();
        }
    }
}