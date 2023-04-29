using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericMethod
    {
        //method takes array as a input
        //T is the data type 
        //in place of T any letter can be used eg. S,M,K,L,parameters,DataType,etc 
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nArray Elements are:");
            foreach(T element in array)
            {
                Console.Write(element+" ");
            }
        }
    }
}
