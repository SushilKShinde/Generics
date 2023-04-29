using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //          className<DataType>
    internal class PrintArrayUsingGenericClassAndMethod<E>
    {
             // MethodName<DataType>(<DataType> argument)
        public static void ToPrint<E>(E[] array)
        {
            Console.WriteLine("\nArray elements are: ");
            foreach(E element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
