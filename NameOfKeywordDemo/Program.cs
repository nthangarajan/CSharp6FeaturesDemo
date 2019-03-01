using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfKeywordDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.PrintEmployee();
        }

        class Employee
        {
            public string FirstName { get; set; } = "Thangarajan";
            public string middleName { get; set; } = "nagarethinam";
            public int Age { get; set; } = 20;
            public double Salary { get; set; } = 1500;
            public double Bonus { get; set; } = 0;



            public void PrintEmployee()
            {
                Console.WriteLine(nameof(FirstName) + FirstName);
                Console.WriteLine(nameof(middleName) + middleName);
                Console.WriteLine(nameof(Age) + Age);
                Console.WriteLine(nameof(Salary) + Salary);
                Console.WriteLine(nameof(Bonus) + Bonus);


                Console.ReadLine();

            }
        }
    }
}
