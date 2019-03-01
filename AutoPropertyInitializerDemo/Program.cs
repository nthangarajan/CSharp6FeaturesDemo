using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.PrintEmployee();
            
            Employee e2 = new Employee { Name = "Raja" };
            e2.PrintEmployee();

        }
    }

    class Employee
    {
        public string Name { get; set; } = "Thanga";
        public int Age { get; set; } = 20;
        public double Salary { get; set; } = 1500;
        public double Bonus { get; set; } = 0;



        public void PrintEmployee()
        {
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Employee Age : " + Age);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Bonus : " + Bonus);
            Console.ReadLine();

        }
    }

}
