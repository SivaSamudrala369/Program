using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Default_Constructors
{ 

class Employee_01
{
    int EmpId;
    string EName, Designation;
    double Salary;
    public Employee_01()
    {
        this.EmpId = 101;
        this.EName = "Raju";
        this.Designation = "Developer";
        this.Salary = 45000;
    }

    public override string ToString()
    {
        string Output = "Employee Id is = " + this.EmpId + "\n" + "Employee name = " + this.EName + "\n" +
        "Employee Designation = " + this.Designation + "\n" + "Employee Salary = " + this.Salary;
        return Output;
    }
}
class Example_01
{
    static void Main()
    {
        Employee_01 E1 = new Employee_01();
        Console.WriteLine(E1);
        Console.ReadLine();
    }
}
}
//output:Employee Id is = 101
//Employee name = Raju
//Employee Designation = Developer
//Employee Salary = 45000


