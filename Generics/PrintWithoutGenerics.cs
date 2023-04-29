using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintWithoutGenerics
    {
        //Method to print integer array
        public static void ToPrint(int[] intArray)
        {
            Console.WriteLine("\nArray elements are:");
            foreach(int element in intArray)
            {
                Console.Write(element+" ");
            }
        }


        //Method to print double array
        public static void ToPrint(double[] doubleArray)
        {
            Console.WriteLine("\nArray elements are:");
            foreach (int element in doubleArray)
            {
                Console.Write(element + " ");
            }
        }

        //Method to print char array
        public static void ToPrint(char[] charArray)
        {
            Console.WriteLine("\nArray elements are:");
            foreach (char element in charArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
