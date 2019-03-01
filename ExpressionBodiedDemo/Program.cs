using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Math m = new Math();
            
            m.PrintResult(m.Add(3, 4));
            Console.ReadLine();
        }

        class Math
        {
            public int Add(int a, int b) => a + b;
            public int Subtract(int a, int b) => a / b;
            public int Mul(int a, int b) => a * b;
            public int Div(int a, int b) => a / b;

            public double PI
            {
                get => 3.14;
                
            }

            public void PrintResult(int result) => Console.WriteLine(nameof(result) + ":" + result);
            

        }

  
    }
}
