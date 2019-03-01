using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new MyException("C# 6.0 Features Exception");
          
        }

    
    }

    [Serializable]
    internal class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
