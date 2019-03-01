using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
              
            //if (e.Name != null)
            //{
            //    Console.WriteLine(e.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Name is null");
            //}
            Console.WriteLine(e?.Name ?? "Name is null");

            Department d = new Department();

            Console.WriteLine(d?.Manager?.Name ?? "manager name is null");
            

            Console.ReadLine();
            
           // string a = d ?? "Depart is null";
            //d?.GetCompanyName() ??


        }


    }

   

    public class Employee
    {
        public string Name { get; set; } = null;
 
    }

    public class Department
    {
        public Employee Manager { get; set; }
        public string Name { get; set; } = "IT";

        public string GetCompanyName()
        {
            return null;
        }
    }

}
