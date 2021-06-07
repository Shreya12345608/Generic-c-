using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doubleArray = { 2.1, 3.1, 4.5 };
            char[] charArray = { 'A', 'B', 'C', 'D' };
            GenericMethod generic = new GenericMethod();
           // generic.ToPrint(intArray);
            //generic.ToPrint<int>(intArray);
            //generic.ToPrint<double>(doubleArray);
            //generic.ToPrint<char>(charArray);
            PrintArrayR <int> printArrayR = new PrintArrayR<int>(intArray);
            printArrayR.ToPrint();

            Console.ReadLine();

        }
    }
}
