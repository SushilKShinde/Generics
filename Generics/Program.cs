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
            Console.WriteLine("Choose from the below options");
            Console.WriteLine("1.Print Array\n");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] intArray = { 10, 20, 30, 40 };
            double[] doubleArray = { 10.20, 20.30, 30.40 };
            char[] charArray = { 'a', 'b', 'c', 'd' };
            switch (option) 
            {
                case 1:
                    PrintWithoutGenerics.ToPrint(intArray);
                    PrintWithoutGenerics.ToPrint(doubleArray);
                    PrintWithoutGenerics.ToPrint(charArray);
                    break;
            }
        }
    }
}

