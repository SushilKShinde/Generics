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
            Console.WriteLine("Program to find maximum int/float/dstring");
            Console.WriteLine("Choose the option");
            Console.WriteLine("\n1.Find Max integere\n2.Find Max float\n3.Find Max string");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first integer");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer");
                    int third = Convert.ToInt32(Console.ReadLine());
                    //call method for max integer 
                    FindMax.FindMaximum(first, second, third);
                    break;
                case 2:
                    Console.WriteLine("Enter first float number");
                    float first_float = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter second float number");
                    float second_float = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter third float number");
                    float third_float = Convert.ToSingle(Console.ReadLine());
                    //call method for max float number
                    FindMax.FindMaximum(first_float, second_float, third_float);
                    break;
                case 3:
                    Console.WriteLine("Enter first string");
                    string first_string = Console.ReadLine();
                    Console.WriteLine("Enter second string");
                    string second_string = Console.ReadLine();
                    Console.WriteLine("Enter third string");
                    string third_string = Console.ReadLine();
                    //call method for max float number
                    FindMax.FindMaximum(first_string, second_string, third_string);
                    break;
                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
        }
    }
}

