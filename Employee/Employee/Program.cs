using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            string deptName = Console.ReadLine();

            Employee e1 = new Employee(id, name, deptName);
            e1.OnFired += new Employee.Fired(called);


            Console.WriteLine("Employee details : ");
            Console.WriteLine("Employee ID :- "+e1.getID());
            Console.WriteLine("Employee Name :-" + e1.getName());
            Console.WriteLine("Employee Department Name :- " + e1.getDepartmentName());

            e1.update(420);
            e1.update("Rohan");
            e1.updateDepName("Account Dept");

            Console.WriteLine("Updated Employee details : ");
            Console.WriteLine("Employee ID :- " + e1.getID());
            Console.WriteLine("Employee Name :-" + e1.getName());
            Console.WriteLine("Employee Department Name :- " + e1.getDepartmentName());

        }

        static void called(string ss)
        {
            Console.WriteLine($"{ss}");
        }
    }
}
