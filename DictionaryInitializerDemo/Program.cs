using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInitializerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, Employee> Employees = new Dictionary<int, Employee>
            //{
            //    {1,new Employee{ Name="Thanga", Age=10} },
            //    {2,new Employee{ Name="Raja", Age=20} },
            //    {3,new Employee{ Name="Rani", Age=30} },

            //};

            Dictionary<int, Employee> Employees = new Dictionary<int, Employee>
            {
                [1] = new Employee{ Name="Thanga", Age=10} ,
                [2] = new Employee{ Name="Raja", Age=20} ,
                [3] = new Employee{ Name="Rani", Age=30} ,

            };
            Employees[1].Age = 45;



            foreach (var item in Employees)
            {
                Employee employee = item.Value;
                Console.WriteLine("Employee Name : " + employee.Name);
                Console.WriteLine("Employee Age : " + employee.Age);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
    }
}
