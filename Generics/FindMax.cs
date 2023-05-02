using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax
    {
        public static void FindMaximum(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine($"{first} is bigger amoung {first} {second} {third}");
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine($"{second} is bigger amoung {first} {second} {third}");
            else
                Console.WriteLine($"{third} is bigger amoung {first} {second} {third} ");
            Console.ReadLine();
        }
        public static void FindMaximum (float first, float second, float third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine($"{first} is bigger amoung {first} {second} {third}");
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine($"{second} is bigger amoung {first} {second} {third}");
            else
                Console.WriteLine($"{third} is bigger amoung {first} {second} {third} ");
            Console.ReadLine();
        }

        public static void FindMaximum(string first, string second, string third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine($"{first} is bigger amoung {first} {second} {third}");
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine($"{second} is bigger amoung {first} {second} {third}");
            else
                Console.WriteLine($"{third} is bigger amoung {first} {second} {third} ");
            Console.ReadLine();
        }
    }
}
