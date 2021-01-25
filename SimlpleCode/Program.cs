using System;
using System.Globalization;

/* 
 * Конвертация строки
 * Класс Convert
 */

namespace SimlpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            string str = Console.ReadLine();
            double.TryParse(str, out double a);
            Console.WriteLine("Введите второе значение");
            str = Console.ReadLine();
            
            double.TryParse(str, out double b);

            double result = (a + b) / 2;

            Console.WriteLine(result);
        }
    }
}
