using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /* 
     * 1) Заполнить массив с клавиатуры;
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");

            int elements = int.Parse(Console.ReadLine());
            int[] myArray = new int[elements];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент с индексом {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}

//2) Вывести массив в обатном порядке;
//*3) Найти сумму четных чисел в массиве;
//*4) Найти наименьшее число в массиве;