using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generic concept impimentation program");
           
            int[] intArray = { 10, 20, 30, 40 };
            double[] doubleArray = { 10.20, 20.30, 30.40 };
            char[] charArray = { 'a', 'b', 'c', 'd' };
            //data type after class name and after method name is required
            PrintArrayUsingGenericClassAndMethod<int>.ToPrint<int>(intArray);
            PrintArrayUsingGenericClassAndMethod<double>.ToPrint<double>(doubleArray);
            PrintArrayUsingGenericClassAndMethod<char>.ToPrint<char>(charArray);
            Console.ReadLine();
        }
    }
}

