using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /* 
     * 
     * 4) Найти наименьшее число в массиве;
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 1};
            int minValue = myArray[0];

            for(int i = 1; i <= myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}