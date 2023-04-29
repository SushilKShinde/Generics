using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericClass<E>
    {
        public static void ToPrint(E[] array)
        {
            Console.WriteLine("\nArray elements are: ");
            foreach(E element in array)
            {
                Console.Write(element+" ");
            }
        }
    }
}
