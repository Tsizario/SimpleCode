using System;

/* 
 * Creating and filling two-dimensional arrays
 */

namespace NewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[,] myArray = new string[3, 3];

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.WriteLine("Y: " + (y+1) + " X: " + (x+1));
                    myArray[y, x] = Console.ReadLine();
                }
            }

            Console.WriteLine();

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {

                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
