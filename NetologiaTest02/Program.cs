using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetologiaTest02_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A

            // Exercise 1

            int[] myArray01 = new int[8];

            myArray01[0] = 0;
            myArray01[1] = 1;

            for (int i = 2; i < myArray01.Length; i++)
            {
                myArray01[i] = myArray01[i - 1] + myArray01[i - 2];
            }



            // Exercise 2

            string[] myArray02 = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



            // Exercise 3

            int[,] myArray03 = new int[3, 3] 
            {
            { 2, 3, 4  },
            { 4, 9, 16, },
            { 8, 27, 64, }
            };



            // Exercise 4

            double[][] myArray04 = new double[3][];

            myArray04[0] = new double[] { 1, 2, 3, 4, 5 };
            myArray04[1] = new double[] { Math.E, Math.PI };
            myArray04[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };



            // B

            // Exercise 5

            int[] array = { 1, 2, 3, 4, 5 }; 
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array.Copy(array, array2, 3);



            // Exercise 6

            Array.Resize(ref array, 10);



            // Вывод в консоль!

            // A

            // Exercise 1

            Console.WriteLine("Exercise 1:\n");

            for (int i = 0; i < myArray01.Length; i++)
            {
                Console.Write(myArray01[i] + " ");
            }

            Console.ReadLine();
            Console.WriteLine("\n\n");



            // Exercise 2

            Console.WriteLine("Exercise 2:\n");

            for (int i = 0; i < myArray02.Length; i++)
            {
                Console.Write(myArray02[i] + " ");
            }

            Console.ReadLine();
            Console.WriteLine(); Console.WriteLine();



            // Exercise 3

            Console.WriteLine("Exercise 3:\n");

            for (int i = 0; i < myArray03.GetLength(0); i++)
            {
                for (int j = 0; j < myArray03.GetLength(1); j++)
                {
                    Console.Write(myArray03[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); 
            Console.WriteLine(); 



            // Exercise 4

            Console.WriteLine("Exercise 4:\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(myArray04[0][i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Write(myArray04[1][i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write(myArray04[2][i] + "\t");
            }

            Console.ReadLine();
            Console.WriteLine(); Console.WriteLine();



            // B

            // Exercise 5

            Console.WriteLine("Exercise 5:\n");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }

            Console.ReadLine();
            Console.WriteLine(); Console.WriteLine();



            // Exercise 6

            Console.WriteLine("Exercise 6:\n");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
