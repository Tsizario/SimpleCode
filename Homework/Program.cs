using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_1
{
    /* 
     * Треугольники в консоли С#
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of triangle: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            for (int i = height; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height-1; j > i; j--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }   
    }
}
