using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject7.Oops
{
    class Employee
    {
        int eid;
        string ename;
        int salary;
        

        static void Main(string []args)
        {
            Employee emp = new Employee();

            emp.eid = 12;
            emp.ename = "neha";
            emp.salary = 75000;
            Console.WriteLine(emp.eid + " " + emp.ename + " " + emp.salary);
            emp.eid = 123;
            emp.ename = "yash";
            emp.salary = 45000;
            Console.WriteLine(emp.eid + " " + emp.ename + " " + emp.salary);
        }

    }
}
