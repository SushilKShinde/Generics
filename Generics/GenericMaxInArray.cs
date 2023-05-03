using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericMaxInArray<T> where T:IComparable
    {
        public T[] array;

        public GenericMaxInArray(T[] array)
        {
            this.array = array;  //initializes array
        }

        public T[] SortArray(T[] array)
        {
            Array.Sort(array);  // sorts array in assending order 2,3,4,,5,6
            return array;
        }

        public T MaxValue(T[] array)
        {
            T[] sortedValue = SortArray(array);
            return sortedValue[array.Length - 1]; //takes last element of sorted array i.e max value
        }

        public void PrinMaxValue()
        {
            T max = MaxValue(array);
            Console.WriteLine($"{max} is maximum value in array");
        }
    }
}
