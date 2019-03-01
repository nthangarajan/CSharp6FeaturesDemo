using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilterInCatchBlockDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpStatusCode = 402;

            Console.WriteLine("HTTP Error " + httpStatusCode);

            try
            {
                throw new Exception(httpStatusCode.ToString());
            }
            //catch (Exception ex)
            //{
            //    if (ex.Message.Equals("500"))
            //    {
            //        Console.WriteLine("Bad Request");
            //    }
            //    else if (ex.Message.Equals("401"))
            //    {
            //        Console.WriteLine("Unauthorized");
            //    }
            //    else if (ex.Message.Equals("402"))
            //    {
            //        Console.WriteLine("Payment required");
            //    }
            //}

            catch (Exception ex) when (ex.Message.Equals("500"))
            {
                Console.WriteLine("Bad Request");
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Console.WriteLine("Unauthorized");
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                Console.WriteLine("All Bad Request");
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Console.WriteLine("Payment required");
            }
          
            Console.ReadLine();

        }
    }
}
