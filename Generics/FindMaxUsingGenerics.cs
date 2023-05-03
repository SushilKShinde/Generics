using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxUsingGenerics<T>  where T: IComparable 
    {
        public T first, second, third;

        public MaxUsingGenerics(T first, T second, T third)
        {
            this.first = first;
            this.second = second;   
            this.third = third;
        }
        public static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{first} is bigger");
                return first;
            }              
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is bigger");
                return second;
            }                
            else
            {
                Console.WriteLine($"{third} is bigger");
                return third;
            }
                
        }

        public T MaxValue()
        {
            T result = MaxUsingGenerics<T>.FindMax(this.first,this.second,this.third);
            return result;
        }
    }
}
