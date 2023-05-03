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
            Console.WriteLine("\n1.Find Max integere\n2.Find Max float\n3.Find Max string\n4.Max using generics\n5.Find Maximum in Array using Generic ");
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
                case 4:
                    {
                        Console.WriteLine("Choose of which data type you want to find maximum");
                        Console.WriteLine("A. IntMax\nB. FloatMAx\nC. StringMax");
                        char option2 = Convert.ToChar(Console.ReadLine());
                        switch (option2)
                        {
                            case 'A':
                                //to find maximun integer
                                Console.WriteLine("Enter first integer");
                                first = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter second integer");
                                second = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter third integer");
                                third = Convert.ToInt32(Console.ReadLine());
                                //call method for max integer 

                                MaxUsingGenerics<int> intMaxValue = new MaxUsingGenerics<int>(first, second, third);
                                intMaxValue.MaxValue();                               
                                break;
                            case 'B':
                                //to find maximun float number
                                Console.WriteLine("Enter first float number");
                                first_float = Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Enter second float number");
                                second_float = Convert.ToSingle(Console.ReadLine());
                                Console.WriteLine("Enter third float number");
                                third_float = Convert.ToSingle(Console.ReadLine());

                                MaxUsingGenerics<float> floatMax = new MaxUsingGenerics<float>(first_float, second_float, third_float);
                                floatMax.MaxValue();
                                break;
                            case 'C':
                                //to find maximun string based on ASCII values
                                Console.WriteLine("Enter first string");
                                first_string = Console.ReadLine();
                                Console.WriteLine("Enter second string");
                                second_string = Console.ReadLine();
                                Console.WriteLine("Enter third string");
                                third_string = Console.ReadLine();
                                
                                MaxUsingGenerics<string> stringMax = new MaxUsingGenerics<string>(first_string, second_string, third_string);   
                                stringMax.MaxValue();
                                break;
                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    break;
                case 5:
                    // to find maximun number in an array
                    int[] intArray = { 45,21,75,95,2,43,85 };
                    GenericMaxInArray<int> obj = new GenericMaxInArray<int>(intArray);
                    obj.PrinMaxValue();
                    break;
                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}

